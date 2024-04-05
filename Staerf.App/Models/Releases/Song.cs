namespace Staerf.App.Models.Releases;

public record Song(string Name, Artist[] Artists, Song? StolenFrom = null);
