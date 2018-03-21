# Tema: **e-Hotel** 

**Članovi tima:**

1.Rožajac Irma

2.Rogo Arnes

## **Opis teme**

U današnje vrijeme, zbog sve većeg broja turista i zbog napredovanja tehnologije dolazimo do zaključka da je potrebno uvesti informacione tehnologije u 
hotel.e-Hotel je sistem koji će omogućavati klijentima da imaju uvid u sve slobodne sobe, te da rezervišu sobu po svom izboru sa svim mogućnostima koje hotel pruža
(da li korisnik želi parking mjesto, da li ima kucnog ljubimca, da li želi dodatni krevet za dijete,da li želi sobu s balkonom,...).
Slično kao i kod rezervacije soba, klijenti koriste sistem da bi rezervisali termin za korištenje spa i wellness centra bez rezervacije
sobe, dok klinijeti koji žele koristiti usluge hotele i boraviti u istom imaju uključenu u cijenu koristenje spa i wellness centra.

Gostima su ovakvi objekti pristupačniji, privlačniji i olakšana im je komunikacija sa osobljem objekta preko aplikacije. Zaposlenicima i šefu je omogućen jednostavan pregled
zahtjeva korisnika i poslova koje trebaju obaviti, omogućen je i pregled rasporeda soba i pristup podacima gostiju u određenim sobama.

## **Procesi**

> Proces iznajmljivanja soba

Korisniku je putem interfejsa omogućeno iznajmljivanje sobe prilikom dolaska u hotel. Automatski se
prikazuju slobodne sobe za uneseni datum za koji je korisnik zainteresovan da rezerviše, a uz to navodi i informacije koju sobu 
želi i posebne zahtjeve ukoliko ih ima (popust za djecu, dodatni krevet, kućni ljubimac, parking) i koliko dugo će odsjedati.
U slučaju da nema slobodnih soba u željenom periodu (npr. trenutno su neke sobe slobodne, ali postoje određene rezervacije, a naš trenutni 
korisnik želi da ostane preko tog datuma), korisniku se prikazuje prvi slobodan datum za rezervaciju određenih soba ili do kojeg datuma su 
sobe slobodne, nakon čega, kada odabare validan datum, vodi ga u daljni proces specifikacije rezervacije.
Nakon potvrđivanja rezervacije, vrši se obračun (mogući su popusti ili dodatni troškovi), te korisnik bira način plaćanja. Popusti na ukupnu cijenu 
od 15% idu za organizacije od 10 i više ljudi.

> Proces rezervacije termina za spa i wellnes centar

Korisnik može odabrati termin za korištenje spa i wellness centra, te izvršiti rezervaciju. Moguće je koristiti ove pogodnosti hotela bez
rezervacije sobe, dok gosti hotela koji borave tu imaju spa i wellnes centar uključen u cijenu.

> Proces realizacija rezervacije

Nakon što se validira rezervacija, podaci se unose u sistem, čistačice i osoblje prilagođavanju sobe eventualnim dodatnim zahtjevima
korisnika i pripremaju sobu. Po završetku odsjedanja čistačica čisti sobu, mjenja posteljinu, iznosi smeće itd. 
Recepcionar potvrdi da li je ključ vraćen ili za izgubljeni ključ naplaćuje dodatno.

> Proces Izvršavanje zahtjeva gosta prilikom boravka

Nakon što je izvršena prijava u sistem i korisniku (gostu) iznajmljena soba, korisniku je putem interfejsa prilikom boravka pružena 
mogućnost postavljanja osnovnih zahtjeva: promjena posteljine, čišćenje sobe, iznošenja smeća, poziv servisera. Nakon izbora pojedinog 
zahtjeva od strane gosta, čistačica ili serviser dobija obavijest o zahtjevu i broju sobe i izvršavaju svoj posao.
Nakon završetka odsjedanja gost boduje usluge i kako je zadovoljan sa sobom i osobljem, kako bi omogućili statistiku objekta.

> Proces plaćanja

Poslije obračuna cijene, korisnik bira način plaćanja(gotovina ili kartica).
Za organizaciju od 10 ili više ljudi na ukupnu cijenu se dobije 15% popusta.


## **Funkcionalnosti**

- mogućnost prijave u sistem sa različitim privilegijama,
- mogućnost online rezervacije sobe (uz navođenje zahtjeva kakvu sobu korisnik želi),
- mogućnost izbora sobe putem interfejsa,
- mogućnost izbora dodatnih zahtjeva korisnika: da li korisnik želi parking mjesto, da li ima kucnog ljubimca, da li želi dodatni krevet,
- mogućnost plaćanja na recepciji (kreditnom karticom ili gotovinsko plaćanje)
- mogućnost rezervacije termina za koristenje spa i wellness centra bez iznajmljivanja sobe,
- mogućnost komunikacije korisnika (gosta) sa osobljem prilikom boravka u objektu, u smislu postavljanja osnovnih zahtjeva kao što su: promjena posteljine, čišćenje sobe, poziv servisera i sl.
- mogućnost osoblja (čistačica, servisera) da vidi zahtjeve gostiju (korisnika) i poslova koje trebaju obaviti,
- mogućnost popusta,
- mogućnost traženja obližnjih kafica i restorana pomoću gps-a,
- mogućnost bodovanja usluga ili sobe od strane gostiju koji su boravili u objektu,
- osoblje sa administrativnim pristupom ima mogućnost pristupa podacima gostiju u rezervisanim/zauzetim sobama,
- mogućnost uvida u statistike objekta


## **Akteri**

1.*Korisnik usluga (gost)* - Korisnik usluga je osoba koja ima mogućnost iznajmljivanja spa i wellness centa i rezervacije sobe.

2.*Recepcionar* – Recepcionar je osoba koja radi na recepciji objekta i vrši naplaćivanje smještaja, izdaje odgovarajaći račun i izdaje sobu gostu (daje gostu ključ od sobe).

3.*Menadžer* – Menadžer objekta predstavlja supervizora koji nadgleda izdavanje soba, ima uvid u podatke gostiju i vrši mjesečnu nabavku posteljine, sredstava za čišćenje i sl.

4.*Serviser* – Serviser je osoba koja se poziva u slučaju potrebnih popravki uređaja.

5.*Čistačica* - Čistačica je osoba koja po odlasku gostiju sprema sobu za nove goste, te po zahtjevima klijenata mjenja posteljinu, uzima veš, smeće,..

6.*Sistem za autorizaciju kartica* – Sistem koji je izvan domena našeg sistema, ali koji komunicira sa našom aplikacijom za realizaciju transakcija plaćanja putem kreditnih kartica.

7.*Sistem za pronalazak obližnjih objekata* - Sistem koje je izvan dometa naseg sistema, ali koji komunicira s nasom aplikacijom za pronalaženje najbližih objekata koji su potrebni klijentu(restorana, apoteke, automata, banke,...).

























