using Flyweight;

var factory = new TextureFactory();

List<Sprite> spriteList = new List<Sprite>();

spriteList.Add(new Sprite("Tex1", "Tex1.svg", 1, 2, factory));
spriteList.Add(new Sprite("Tex2", "Tex2.svg", 3, 4, factory));
spriteList.Add(new Sprite("Tex3", "Tex1.svg", 5, 6, factory));
spriteList.Add(new Sprite("Tex4", "Tex2.svg", 7, 8, factory));
spriteList.Add(new Sprite("Tex5", "Tex3.svg", 9, 10, factory));

foreach (var sprite in spriteList)
{
    sprite.Draw();
}