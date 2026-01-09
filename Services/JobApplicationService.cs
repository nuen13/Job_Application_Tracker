using Microsoft.EntityFrameworkCore;
using Job_Application_Tracker.Data;
using Job_Application_Tracker.Models;



namespace Job_Application_Tracker.Services{
    public class JobApplicationService
{
    private readonly AppDbContext _context;

    public JobApplicationService(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<JobApplication>> GetAllAsync()
    {
        return await _context.JobApplications.ToListAsync();
    }

    public async Task<JobApplication?> GetByIdAsync(Guid id)
    {
        return await _context.JobApplications.FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task AddAsync(JobApplication app)
    {
        _context.JobApplications.Add(app);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(JobApplication updatedApp)
    {
        _context.JobApplications.Update(updatedApp);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Guid id)
    {
        var app = await _context.JobApplications.FirstOrDefaultAsync(a => a.Id == id);

        if (app != null)
        {
            _context.JobApplications.Remove(app);
            await _context.SaveChangesAsync();
        }
    }
}
}
