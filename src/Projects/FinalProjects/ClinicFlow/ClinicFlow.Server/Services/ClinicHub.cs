using Microsoft.AspNetCore.SignalR;

public class ClinicHub : Hub
{
    public async Task NotifyDashboardUpdate(string message)
    {
        await Clients.All.SendAsync("ReceiveDashboardUpdate", message);
    }
}
