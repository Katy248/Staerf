using Staerf.App.Models.Releases;

namespace Staerf.App.Repositories;

public class SongsRepository
{

    public IEnumerable<Song> GetSongs()
    {
        Artist _staerf = new("Staerf", "staerf");
        Artist _otets = new("OTETS", "otets");
        Artist _s = new("C...", "s");
        Artist _via = new("ВИА Гра", "viagra");
        Artist _alSt = new("Alexandra Stan", "viagra");

        Song _fifthTry = new Song("ВИА Гра - Моя попытка №5", [_via]);
        Song _saxobeat = new Song("Mr. Saxobeat", [_alSt]);

        Song[] songs =
        [
            new Song("Alien",[_staerf], _saxobeat),
            new Song("Depth",[_staerf, _otets]),
            new Song("Drift", [_staerf]),
            new Song("Deo",[_staerf], _fifthTry),
            new Song("Money",[_s]),
            _fifthTry, _saxobeat,
        ];

        return songs;
    }
}
