namespace Grains
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Contracts;

    using Orleans;

    public class GameGrain : Grain, IGameGrain
    {
        private HashSet<string> players;

        public GameGrain() => this.players = new HashSet<string>();

        public Task JoinAsync(string playerName)
        {
            this.players.Add(playerName);
            return Task.CompletedTask;
        }

        public Task LeaveAsync(string playerName)
        {
            this.players.Remove(playerName);
            return Task.CompletedTask;
        }

        public Task<List<string>> ListPlayersAsync()
            => Task.FromResult(this.players.ToList());
    }
}
