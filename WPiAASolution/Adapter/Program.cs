using Adapter;

Teenager krzys = new Teenager("Krzyś", 17);

Bouncer bramkarz = new Bouncer();
FakeAdult falszywyDowodKrzysia = new FakeAdult(krzys);

bramkarz.CheckId(falszywyDowodKrzysia);