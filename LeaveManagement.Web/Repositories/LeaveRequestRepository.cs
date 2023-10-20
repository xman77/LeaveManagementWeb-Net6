﻿using AutoMapper;
using LeaveManagement.Web.Contracts;
using LeaveManagement.Web.Data;
using LeaveManagement.Web.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>, ILeaveRequestRepository
    {
        private readonly ApplicationDbContext context;
        private readonly IMapper mapper;
        private readonly IHttpContextAccessor httpContextAccessor;
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly UserManager<Employee> userManger;

        public LeaveRequestRepository(ApplicationDbContext context,
            IMapper mapper,
            IHttpContextAccessor httpContextAccessor,
            ILeaveAllocationRepository leaveAllocationRepository,
            UserManager<Employee> userManger) : base(context)
        {
            this.context = context;
            this.mapper = mapper;
            this.httpContextAccessor = httpContextAccessor;
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.userManger = userManger;
        }

        public async Task CreateLeaveRequest(LeaveRequestCreateVM model)
        {
            var user = await userManger.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            var leaveRequest = mapper.Map<LeaveRequest>(model);
            leaveRequest.DateRequested = DateTime.Now;
            leaveRequest.RequestingEmployeeId = user.Id;

            await AddAsync(leaveRequest);

        }

        public async Task<List<LeaveRequest>> GetAllAsync(string employeeId)
        {
            return await context.LeaveRequest.Where(q => q.RequestingEmployeeId == employeeId).ToListAsync();
        }

        public async Task<EmployeeLeaveRequestViewVM> GetMyLeaveDetails()
        {
            var user = await userManger.GetUserAsync(httpContextAccessor?.HttpContext?.User);
            var allocations = (await leaveAllocationRepository.GetEmployeeAllocations(user.Id)).LeaveAllocations;
            var requests =  mapper.Map<List<LeaveRequestVM>>(await GetAllAsync(user.Id));
            var model = new EmployeeLeaveRequestViewVM(allocations, requests);

            return model;
        }
    }
}
