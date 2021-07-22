using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISites
{
    public class RepoInitial
    {
        private ApplicationContext _context;

        public RepoInitial(ApplicationContext _db)
        {
            _context = _db
               ?? throw new ArgumentException(nameof(_db));
        }

        public void Initial()
        {
            // InitialTableCountry();
            // InitialTableIssuer();

            Fill();
        }

        private void Fill()
        {

            // 
            Models.Country BA = new Models.Country { Name = "Bosnia and Herzegovina", Name_RU = "Босния и Герцеговина", Code_A2 = "BA", Code_A3 = "BIH", Code_Num = 070, Currency = "BAM" };
            Models.Country BG = new Models.Country { Name = "Bulgaria", Name_RU = "Болгария", Code_A2 = "BG", Code_A3 = "BGR", Code_Num = 100, Currency = "BGN" };
            Models.Country BY = new Models.Country { Name = "Belarus", Name_RU = "Беларусь", Code_A2 = "BY", Code_A3 = "BLR", Code_Num = 112, Currency = "BYN" };
            Models.Country CZ = new Models.Country { Name = "Czechia", Name_RU = "Чехия", Code_A2 = "CZ", Code_A3 = "CZE", Code_Num = 203, Currency = "CZK"};
            Models.Country EE = new Models.Country { Name = "Estonia", Name_RU = "Эстония", Code_A2 = "EE", Code_A3 = "EST", Code_Num = 233, Currency = "EUR" };
            Models.Country GB = new Models.Country { Name = "United Kingdom", Name_RU = "Великобритания", Code_A2 = "GB", Code_A3 = "GBR", Code_Num = 826, Currency = "GBP" };
            Models.Country HR = new Models.Country { Name = "Croatia", Name_RU = "Хорватия", Code_A2 = "HR", Code_A3 = "HRV", Code_Num = 191, Currency = "HRK" };
            Models.Country HU = new Models.Country { Name = "Hungary", Name_RU = "Венгрия", Code_A2 = "HU", Code_A3 = "HUN", Code_Num = 348, Currency = "HUF" };
            Models.Country LT = new Models.Country { Name = "Lithuania", Name_RU = "Литва", Code_A2 = "LT", Code_A3 = "LTU", Code_Num = 440, Currency = "EUR" };
            Models.Country LV = new Models.Country { Name = "Latvia", Name_RU = "Латвия", Code_A2 = "LV", Code_A3 = "LVA", Code_Num = 428, Currency = "EUR" };
            Models.Country MD = new Models.Country { Name = "Moldova", Name_RU = "Молдавия", Code_A2 = "MD", Code_A3 = "MDA", Code_Num = 498, Currency = "MDL" };
            Models.Country PL = new Models.Country { Name = "Poland", Name_RU = "Польша", Code_A2 = "PL", Code_A3 = "POL", Code_Num = 616, Currency = "PLN" };
            Models.Country RO = new Models.Country { Name = "Romania", Name_RU = "Румыния", Code_A2 = "RO", Code_A3 = "ROU", Code_Num = 642, Currency = "RON" };
            Models.Country RS = new Models.Country { Name = "Serbia", Name_RU = "Сербия", Code_A2 = "RS", Code_A3 = "SRB", Code_Num = 688, Currency = "RSD" };
            Models.Country RU = new Models.Country { Name = "Russian Federation", Name_RU = "Россия", Code_A2 = "RU", Code_A3 = "RUS", Code_Num = 643, Currency = "RUB" };
            Models.Country SI = new Models.Country { Name = "Slovenia", Name_RU = "Словения", Code_A2 = "SI", Code_A3 = "SVN", Code_Num = 705, Currency = "EUR" };
            Models.Country SK = new Models.Country { Name = "Slovakia", Name_RU = "Словакия", Code_A2 = "SK", Code_A3 = "SVK", Code_Num = 703, Currency = "EUR" };
            Models.Country UA = new Models.Country { Name = "Ukraine", Name_RU = "Украина", Code_A2 = "UA", Code_A3 = "UKR", Code_Num = 804, Currency = "UAH" };

            _context.Country.AddRange(BA, BG, BY, CZ, EE, GB, HR, HU, LT, LV, MD, PL, RO, RS, RU, SI, SK, UA);
            _context.SaveChanges();

            Models.Issuer DKV = new Models.Issuer { IssuerCode = 0, IssuerName = "DKV" };
            Models.Issuer UTA = new Models.Issuer { IssuerCode = 1, IssuerName = "UTA" };
            Models.Issuer SHELL = new Models.Issuer { IssuerCode = 2, IssuerName = "SHELL" };
            Models.Issuer ROUTEX = new Models.Issuer { IssuerCode = 3, IssuerName = "ROUTEX" };
            Models.Issuer E100 = new Models.Issuer { IssuerCode = 4, IssuerName = "E100" };
            Models.Issuer OLEREX = new Models.Issuer { IssuerCode = 5, IssuerName = "OLEREX" };
            Models.Issuer SHELLOY = new Models.Issuer { IssuerCode = 8, IssuerName = "SHELLOY" };
            Models.Issuer SCANOIL = new Models.Issuer { IssuerCode = 10, IssuerName = "SCANOIL" };
            Models.Issuer AUTOCARD = new Models.Issuer { IssuerCode = 23, IssuerName = "AUTOCARD" };
            Models.Issuer Q8 = new Models.Issuer { IssuerCode = 70, IssuerName = "Q8" };
            Models.Issuer BENZOVOZ = new Models.Issuer { IssuerCode = 80, IssuerName = "BENZOVOZ" };
            Models.Issuer YANDEX = new Models.Issuer { IssuerCode = 90, IssuerName = "YANDEX" };

            _context.Issuer.AddRange(DKV, UTA, SHELL, ROUTEX, E100, OLEREX, SHELLOY, SCANOIL, AUTOCARD, Q8, BENZOVOZ, YANDEX);
            _context.SaveChanges();

            Models.Product _001 = new Models.Product { ProductCode = 1, ProductName = "001" };
            Models.Product _002 = new Models.Product { ProductCode = 2, ProductName = "002" };
            Models.Product _062 = new Models.Product { ProductCode = 3, ProductName = "062" };
            Models.Product _101 = new Models.Product { ProductCode = 4, ProductName = "101" };
            Models.Product _102 = new Models.Product { ProductCode = 5, ProductName = "102" };
            Models.Product _171 = new Models.Product { ProductCode = 6, ProductName = "171" };
            Models.Product _3MONTHVIGNETTEEE1 = new Models.Product { ProductCode = 7, ProductName = "3MONTH-VIGNETTE-EE" };
            Models.Product _95VPOWER = new Models.Product { ProductCode = 8, ProductName = "95 V-POWER" };
            Models.Product _A92 = new Models.Product { ProductCode = 9, ProductName = "A-92" };
            Models.Product _A95 = new Models.Product { ProductCode = 10, ProductName = "A-95" };

            _context.Product.AddRange(_001, _002, _062, _101, _102, _171, _3MONTHVIGNETTEEE1, _95VPOWER, _A92, _A95);
            _context.SaveChanges();

            // БЕЛАРУСЬ
            Models.Owner Lukoil = new Models.Owner { OwnerCode = 2, OwnerName = "Lukoil", Country = BY};
            Models.Owner Grodnooblnefteproduct = new Models.Owner { OwnerCode = 3, OwnerName = "Grodnooblnefteproduct", Country = BY };
            Models.Owner United_Company = new Models.Owner { OwnerCode = 5, OwnerName = "United_Company", Country = BY };
            Models.Owner Volkovysk = new Models.Owner { OwnerCode = 6, OwnerName = "Volkovysk", Country = BY };
            Models.Owner GOil = new Models.Owner { OwnerCode = 7, OwnerName = "GOil", Country = BY };
            Models.Owner Smorgon = new Models.Owner { OwnerCode = 13, OwnerName = "Smorgon", Country = BY };
            Models.Owner WestaBY = new Models.Owner { OwnerCode = 14, OwnerName = "WestaBY", Country = BY };
            Models.Owner OROKS = new Models.Owner { OwnerCode = 15, OwnerName = "OROKS", Country = BY };
            Models.Owner RNWEST = new Models.Owner { OwnerCode = 16, OwnerName = "RN-WEST", Country = BY };
            Models.Owner GAZPROM = new Models.Owner { OwnerCode = 17, OwnerName = "GAZPROM", Country = BY };
            Models.Owner BELTAMOZHSERVICE = new Models.Owner { OwnerCode = 41, OwnerName = "BELTAMOZHSERVICE", Country = BY };
            // ЛИТВА
            Models.Owner MEDBANKAS = new Models.Owner { OwnerCode = 43, OwnerName = "MEDBANKAS", Country = LT };
            Models.Owner BERZO_LAPAS = new Models.Owner { OwnerCode = 44, OwnerName = "BERZO_LAPAS", Country = LT };
            Models.Owner MONETIS = new Models.Owner { OwnerCode = 45, OwnerName = "MONETIS", Country = LT };
            Models.Owner UNIKALL = new Models.Owner { OwnerCode = 46, OwnerName = "UNIKALL", Country = LT };

            _context.Owner.AddRange(Lukoil, Grodnooblnefteproduct, United_Company, Volkovysk, GOil, Smorgon, WestaBY, OROKS, RNWEST, GAZPROM, BELTAMOZHSERVICE, MEDBANKAS,
                BERZO_LAPAS, MONETIS, UNIKALL);
            _context.SaveChanges();

            Models.Pos LukoilPershai2_6 = new Models.Pos { PosCode = 6, PosName = "Lukoil Pershai 2-6", Owner = Lukoil, Adress = " " };
            Models.Pos LukoilBrest11 = new Models.Pos { PosCode = 11, PosName = "Lukoil, Brest-11", Owner = Lukoil, Adress = " " };
            Models.Pos LukoilBrest12 = new Models.Pos { PosCode = 12, PosName = "Lukoil, Brest-12", Owner = Lukoil, Adress = " " };
            Models.Pos BelarusneftBruzgi = new Models.Pos { PosCode = 9, PosName = "Belarusneft, Bruzgi", Owner = Grodnooblnefteproduct, Adress = " " };
            Models.Pos Gozha = new Models.Pos { PosCode = 53, PosName = "Gozha", Owner = Grodnooblnefteproduct, Adress = " " };
            Models.Pos SalociuPasvalys = new Models.Pos { PosCode = 1, PosName = "Salociu Pasvalys", Owner = MEDBANKAS, Adress = " " };
            Models.Pos Kalvarijos = new Models.Pos { PosCode = 2, PosName = "Kalvarijos", Owner = MEDBANKAS, Adress = " " };
            Models.Pos Medininkai = new Models.Pos { PosCode = 4, PosName = "Medininkai", Owner = MEDBANKAS, Adress = " " };
            Models.Pos Salaperaugio = new Models.Pos { PosCode = 6, PosName = "Salaperaugio", Owner = MEDBANKAS, Adress = " " };

            _context.Pos.AddRange(LukoilPershai2_6, LukoilBrest11, LukoilBrest12, BelarusneftBruzgi, Gozha, SalociuPasvalys, Kalvarijos, Medininkai, Salaperaugio);
            _context.SaveChanges();

            Models.PosIssuer LukoilPershai2_6TODKV = new Models.PosIssuer { Pos = LukoilPershai2_6, Issuer = DKV, IssuerPosCode = 1111 };
            Models.PosIssuer LukoilPershai2_6TOUTA = new Models.PosIssuer { Pos = LukoilPershai2_6, Issuer = UTA, IssuerPosCode = 2222 };
            Models.PosIssuer LukoilPershai2_6TOSHELL = new Models.PosIssuer { Pos = LukoilPershai2_6, Issuer = SHELL, IssuerPosCode = 3333 };
            Models.PosIssuer LukoilPershai2_6TOROUTEX = new Models.PosIssuer { Pos = LukoilPershai2_6, Issuer = ROUTEX, IssuerPosCode = 4444 };

            _context.PosIssuer.AddRange(LukoilPershai2_6TODKV, LukoilPershai2_6TOUTA, LukoilPershai2_6TOSHELL, LukoilPershai2_6TOROUTEX);
            _context.SaveChanges();


            _context.IssuerProduct.Add(new Models.IssuerProduct { PosIssuer = LukoilPershai2_6TODKV, Product = _95VPOWER, IssuerProductCode = 98734569 });
            _context.IssuerProduct.Add(new Models.IssuerProduct { PosIssuer = LukoilPershai2_6TODKV, Product = _A92, IssuerProductCode = 324435 });
            _context.IssuerProduct.Add(new Models.IssuerProduct { PosIssuer = LukoilPershai2_6TODKV, Product = _A95, IssuerProductCode = 34656 });

            _context.SaveChanges();
        }


        private void InitialTableCountry()
        {
            _context.Country.Add(new Models.Country { Name = "Bosnia and Herzegovina", Name_RU = "Босния и Герцеговина", Code_A2 = "BA", Code_A3 = "BIH", Code_Num = 070, Currency = "BAM" });
            _context.Country.Add(new Models.Country { Name = "Bulgaria", Name_RU = "Болгария", Code_A2 = "BG", Code_A3 = "BGR", Code_Num = 100, Currency = "BGN" });
            _context.Country.Add(new Models.Country { Name = "Belarus", Name_RU = "Беларусь", Code_A2 = "BY", Code_A3 = "BLR", Code_Num = 112, Currency = "BYN" });
            _context.Country.Add(new Models.Country { Name = "Czechia", Name_RU = "Чехия", Code_A2 = "CZ", Code_A3 = "CZE", Code_Num = 203, Currency = "CZK" });
            _context.Country.Add(new Models.Country { Name = "Estonia", Name_RU = "Эстония", Code_A2 = "EE", Code_A3 = "EST", Code_Num = 233, Currency = "EUR" });
            _context.Country.Add(new Models.Country { Name = "United Kingdom", Name_RU = "Великобритания", Code_A2 = "GB", Code_A3 = "GBR", Code_Num = 826, Currency = "GBP" });
            _context.Country.Add(new Models.Country { Name = "Croatia", Name_RU = "Хорватия", Code_A2 = "HR", Code_A3 = "HRV", Code_Num = 191, Currency = "HRK" });
            _context.Country.Add(new Models.Country { Name = "Hungary", Name_RU = "Венгрия", Code_A2 = "HU", Code_A3 = "HUN", Code_Num = 348, Currency = "HUF" });
            _context.Country.Add(new Models.Country { Name = "Lithuania", Name_RU = "Литва", Code_A2 = "LT", Code_A3 = "LTU", Code_Num = 440, Currency = "EUR" });
            _context.Country.Add(new Models.Country { Name = "Latvia", Name_RU = "Латвия", Code_A2 = "LV", Code_A3 = "LVA", Code_Num = 428, Currency = "EUR" });
            _context.Country.Add(new Models.Country { Name = "Moldova", Name_RU = "Молдавия", Code_A2 = "MD", Code_A3 = "MDA", Code_Num = 498, Currency = "MDL" });
            _context.Country.Add(new Models.Country { Name = "Poland", Name_RU = "Польша", Code_A2 = "PL", Code_A3 = "POL", Code_Num = 616, Currency = "PLN" });
            _context.Country.Add(new Models.Country { Name = "Romania", Name_RU = "Румыния", Code_A2 = "RO", Code_A3 = "ROU", Code_Num = 642, Currency = "RON" });
            _context.Country.Add(new Models.Country { Name = "Serbia", Name_RU = "Сербия", Code_A2 = "RS", Code_A3 = "SRB", Code_Num = 688, Currency = "RSD" });
            _context.Country.Add(new Models.Country { Name = "Russian Federation", Name_RU = "Россия", Code_A2 = "RU", Code_A3 = "RUS", Code_Num = 643, Currency = "RUB" });
            _context.Country.Add(new Models.Country { Name = "Slovenia", Name_RU = "Словения", Code_A2 = "SI", Code_A3 = "SVN", Code_Num = 705, Currency = "EUR" });
            _context.Country.Add(new Models.Country { Name = "Slovakia", Name_RU = "Словакия", Code_A2 = "SK", Code_A3 = "SVK", Code_Num = 703, Currency = "EUR" });
            _context.Country.Add(new Models.Country { Name = "Ukraine", Name_RU = "Украина", Code_A2 = "UA", Code_A3 = "UKR", Code_Num = 804, Currency = "UAH" });

            _context.SaveChanges();
        }

        private void InitialTableIssuer()
        {
            _context.Issuer.Add(new Models.Issuer { IssuerCode = 0, IssuerName = "DKV"  });
            _context.Issuer.Add(new Models.Issuer { IssuerCode = 1, IssuerName = "UTA" });
            _context.Issuer.Add(new Models.Issuer { IssuerCode = 2, IssuerName = "SHELL" });
            _context.Issuer.Add(new Models.Issuer { IssuerCode = 3, IssuerName = "ROUTEX" });
            _context.Issuer.Add(new Models.Issuer { IssuerCode = 4, IssuerName = "E100" });
            _context.Issuer.Add(new Models.Issuer { IssuerCode = 5, IssuerName = "OLEREX" });
            _context.Issuer.Add(new Models.Issuer { IssuerCode = 8, IssuerName = "SHELLOY" });
            _context.Issuer.Add(new Models.Issuer { IssuerCode = 10, IssuerName = "SCANOIL" });
            _context.Issuer.Add(new Models.Issuer { IssuerCode = 23, IssuerName = "AUTOCARD" });
            _context.Issuer.Add(new Models.Issuer { IssuerCode = 70, IssuerName = "Q8" });
            _context.Issuer.Add(new Models.Issuer { IssuerCode = 80, IssuerName = "BENZOVOZ" });
            _context.Issuer.Add(new Models.Issuer { IssuerCode = 90, IssuerName = "YANDEX" });
            
            _context.SaveChanges();
        }

    }
}
