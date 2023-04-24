using Microsoft.EntityFrameworkCore;
using RaportProduction.Application.Common.Interfaces;

namespace RaportProduction.Infrastructure.Services;

public class AppSettingsService : IAppSettingsService
{
    private Dictionary<string, string> _appSettings = new Dictionary<string, string>();

    private SemaphoreSlim _semaphore= new SemaphoreSlim(1,1);

    private async Task Wait()
    {
        await _semaphore.WaitAsync();
    }

    private void Release()
    {
        _semaphore.Release();
    }

    public async Task<string> Get(string key)
    {
        try
        {
            await Wait();
            return _appSettings[key];
        }
        finally
        {
            Release();
        }
    }

    public async Task Update(IApplicationDbContext context)
    {
        try
        {
            await Wait();

            _appSettings.Clear();

            var settingsPositions = await context
                .SettingPositions
                .AsNoTracking()
                .ToListAsync();

            foreach (var position in settingsPositions)
            {
                _appSettings.Add(position.Key, position.Value);
            }

        }
        finally
        {
            Release();
        }
    }
}
