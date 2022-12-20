using System.Net.Http.Json;

namespace MovieApp.MovieAppData
{
    public class MovieAppDataService
    {
        private readonly HttpClient http;

        public MovieAppDataService(HttpClient http)
        {
            this.http = http;
        }

        public async Task<NowPlayingType[]?> GetNowPlaying()
        {
            using HttpResponseMessage response = await http.GetAsync("https://excel2json.io/api/share/15755be7-cee3-4b74-4382-08da496bf5f2").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<NowPlayingType[]>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<MovieListType[]?> GetMovieList()
        {
            using HttpResponseMessage response = await http.GetAsync("https://excel2json.io/api/share/99cd7568-0b49-4c09-4387-08da496bf5f2").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<MovieListType[]>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<TheatresType[]?> GetTheatres()
        {
            using HttpResponseMessage response = await http.GetAsync("https://excel2json.io/api/share/5435e256-3846-4895-4385-08da496bf5f2").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TheatresType[]>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<ShowtimesType[]?> GetShowtimes()
        {
            using HttpResponseMessage response = await http.GetAsync("https://excel2json.io/api/share/f179620a-3bb6-49cd-4384-08da496bf5f2").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<ShowtimesType[]>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<TheatresNearYouType[]?> GetTheatresNearYou()
        {
            using HttpResponseMessage response = await http.GetAsync("https://excel2json.io/api/share/49f543dc-9c4e-43e8-4386-08da496bf5f2").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<TheatresNearYouType[]>().ConfigureAwait(false);
            }

            return null;
        }

        public async Task<MyPurchasesType[]?> GetMyPurchases()
        {
            using HttpResponseMessage response = await http.GetAsync("https://excel2json.io/api/share/3f89384c-e58f-429a-4388-08da496bf5f2").ConfigureAwait(false);
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadFromJsonAsync<MyPurchasesType[]>().ConfigureAwait(false);
            }

            return null;
        }
    }
}