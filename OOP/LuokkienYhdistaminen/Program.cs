//luodaan opettajat, oppilaat ja moduulit
Opettaja Opettaja1 = new Opettaja("Kalervo");
Oppilas Oppilas1 = new Oppilas("Kukka");
Moduuli Moduuli1 = new Moduuli("Orientaatio");

Opettaja Opettaja2 = new Opettaja("Kirsikka");
Oppilas Oppilas2 = new Oppilas("Sakari");
Moduuli Moduuli2 = new Moduuli("Ohjelmointi");

//lisätään opettajat moduuleihin
Moduuli1.LisaaOpettaja(Opettaja1);
Moduuli2.LisaaOpettaja(Opettaja1);
Moduuli1.LisaaOpettaja(Opettaja2);
Moduuli2.LisaaOpettaja(Opettaja2);

//lisätään moduulit oppilaille
Oppilas1.LisaaModuuli(Moduuli1);
Oppilas2.LisaaModuuli(Moduuli1);
Oppilas1.LisaaModuuli(Moduuli2);
Oppilas2.LisaaModuuli(Moduuli2);

//tulosta tieto
Oppilas1.Tulosta();
Oppilas2.Tulosta();


