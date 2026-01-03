using PexelsDotNetSDK.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal abstract class PhotoStrategy
    {
        internal abstract Task Search(string category);
    }

    internal class PexelsDatabase : PhotoStrategy
    {
        async internal override Task Search(string category)
        {
            var pexelsClient = new PexelsClient("API_KEY");
            try
            {
                var searchResult = await pexelsClient.SearchPhotosAsync(query: category);

                if (searchResult != null && searchResult.photos != null)
                {
                    Console.WriteLine($"Search Results found for '{category}' in Pexels\n");
                    foreach (var photo in searchResult.photos)
                    {
                        Console.WriteLine($"Photo ID: {photo.id}, Photographer: {photo.photographer}, URL: {photo.url}");
                    }
                }
                else
                {
                    Console.WriteLine($"No results found for '{category}' in Pexels.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Wystąpił błąd: {ex.Message}");
            }
        }
    }

    internal class PixabayDatabase : PhotoStrategy
    {
        async internal override Task Search(string category)
        {
            var apiKey = "API_KEY";
            var url = "https://pixabay.com/api/?key=" + apiKey + "&q=" + Uri.EscapeDataString(category);
            var client = new HttpClient();
            var response = await client.GetStringAsync(url);
            Console.WriteLine($"Search Results found for '{category}' in Pixabay\n");
            Console.WriteLine(response);
        }
    }

    internal class PhotoDatabase
    {

        private PhotoStrategy? _photoStrategy;
        internal void SetStrategy(PhotoStrategy photoStrategy)
        {
            _photoStrategy = photoStrategy;
        }
        async internal Task SearchPhotos(string category)
        {
            await _photoStrategy!.Search(category);
        }
    }
}
