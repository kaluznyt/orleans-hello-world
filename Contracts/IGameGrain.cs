namespace Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using Orleans;

    public interface IGameGrain : IGrainWithIntegerKey
    {
        Task JoinAsync(string playerName);
        Task LeaveAsync(string playerName);
        Task<List<string>> ListPlayersAsync();
    }
}
