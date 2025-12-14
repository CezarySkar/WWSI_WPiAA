
using Composite;

MenuCat mainMenu = new MenuCat("Menu Główne");

MenuCat mainCourse = new MenuCat("Dania Główne");
mainCourse.addItem(new Dish("stek", 12.12m));
mainCourse.addItem(new Dish("kurczak", 10.10m));

MenuCat desserts = new MenuCat("Desery");
desserts.addItem(new Dish("lody", 5.50m));
desserts.addItem(new Dish("ciasto", 6.60m));

MenuCat drinks = new MenuCat("Napoje");
drinks.addItem(new Dish("cola", 3.30m));
drinks.addItem(new Dish("woda", 2.20m));

mainMenu.addItem(mainCourse);
mainMenu.addItem(desserts);
mainMenu.addItem(drinks);

mainMenu.Display(0);