using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class TextureFactory
    {
        private readonly Dictionary<string, Texture> _textures = new();
        public Texture GetTexture(string textureType)
        {
            if (!_textures.ContainsKey(textureType))
            {
                var texture = new Texture(textureType);
                _textures[textureType] = texture;
            }
            return _textures[textureType];
        }
    }
}
