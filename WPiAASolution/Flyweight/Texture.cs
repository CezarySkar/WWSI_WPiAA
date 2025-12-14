using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Texture
    {
        public Guid Id;
        public string? FileName;
        public string? TextureData;

        public Texture(string textureType)
        {
            Id = Guid.NewGuid();
            FileName = $"{textureType}.svg";
            TextureData = $"Texture data for {textureType}";
        }
    }
}
