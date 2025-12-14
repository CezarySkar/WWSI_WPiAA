using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Sprite
    {
        public string Name { get; set; }
        public string TexturePath { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public Texture Texture { get; set; }
        public Sprite(string name, string texturePath, int x, int y, TextureFactory textureFactory) 
        {
            Name = name;
            TexturePath = texturePath;
            X = x;
            Y = y;
            Texture = textureFactory.GetTexture(texturePath);
        }

        public void Draw()
        {
            Console.WriteLine($"Drawing sprite '{Name}' at ({X}, {Y}) with texture from '{TexturePath}', texture ID: {Texture.Id}");
        }
    }
}
