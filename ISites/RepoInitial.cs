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
