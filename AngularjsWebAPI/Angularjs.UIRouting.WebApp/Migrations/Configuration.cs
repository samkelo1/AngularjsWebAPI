namespace Angularjs.UIRouting.WebApp.Migrations
{
    using Angularjs.UIRouting.WebApp.DataAccessLayer;
    using Angularjs.UIRouting.WebApp.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(DataContext context)
        {
            var Users = new List<User>{
                new User { UserId = 1, FullName = "Alejandra Camino", Address = "Gran V�a, 1", City = "Madrid", ZipCode = "28001", Country = "Spain", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 2, FullName = "Alexander Feuer", Address = "Heerstr. 22", City = "Leipzig", ZipCode = "04179", Country = "Germany", Image = "/UserImages/image-2.jpg" },
                new User { UserId = 3, FullName = "Ana Trujillo", Address = "Avda. de la Constituci�n 2222", City = "M�xico D.F.", ZipCode = "05021", Country = "Mexico", Image = "/UserImages/image-3.jpg" },
                new User { UserId = 4, FullName = "Anabela Domingues", Address = "Av. In�s de Castro, 414", City = "Sao Paulo", ZipCode = "05634-030", Country = "Brazil", Image = "/UserImages/image-4.jpg" },
                new User { UserId = 5, FullName = "Andr� Fonseca", Address = "Av. Brasil, 442", City = "Campinas", ZipCode = "04876-786", Country = "Brazil", Image = "/UserImages/image-5.jpg" },
                new User { UserId = 6, FullName = "Ann Devon", Address = "35 King George", City = "London", ZipCode = "WX3 6FW", Country = "UK", Image = "/UserImages/image-6.jpg" },
                new User { UserId = 7, FullName = "Annette Roulet", Address = "1 rue Alsace-Lorraine", City = "Toulouse", ZipCode = "31000", Country = "France", Image = "/UserImages/image-7.jpg" },
                new User { UserId = 8, FullName = "Antonio Moreno", Address = "Mataderos  2312", City = "M�xico D.F.", ZipCode = "05023", Country = "Mexico", Image = "/UserImages/image-8.jpg" },
                new User { UserId = 9, FullName = "Aria Cruz", Address = "Rua Or�s, 92", City = "Sao Paulo", ZipCode = "05442-030", Country = "Brazil", Image = "/UserImages/image-9.jpg" },
                new User { UserId = 10, FullName = "Art Braunschweiger", Address = "P.O. Box 555", City = "Lander", ZipCode = "82520", Country = "USA", Image = "/UserImages/image-10.jpg" },
                new User { UserId = 11, FullName = "Bernardo Batista", Address = "Rua da Panificadora, 12", City = "Rio de Janeiro", ZipCode = "02389-673", Country = "Brazil", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 12, FullName = "Carine Schmitt", Address = "54, rue Royale", City = "Nantes", ZipCode = "44000", Country = "France", Image = "/UserImages/image-6.jpg" },
                new User { UserId = 13, FullName = "Carlos Gonz�lez", Address = "Carrera 52 con Ave. Bol�var #65-98 Llano Largo", City = "Barquisimeto", ZipCode = "3508", Country = "Venezuela", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 14, FullName = "Carlos Hern�ndez", Address = "Carrera 22 con Ave. Carlos Soublette #8-35", City = "San Crist�bal", ZipCode = "5022", Country = "Venezuela", Image = "/UserImages/image-7.jpg" },
                new User { UserId = 15, FullName = "Catherine Dewey", Address = "Rue Joseph-Bens 532", City = "Bruxelles", ZipCode = "B-1180", Country = "Belgium", Image = "/UserImages/image-5.jpg" },
                new User { UserId = 16, FullName = "Christina Berglund", Address = "Berguvsv�gen  8", City = "Lule�", ZipCode = "S-958 22", Country = "Sweden", Image = "/UserImages/image-8.jpg" },
                new User { UserId = 17, FullName = "Daniel Tonini", Address = "67, avenue de l'Europe", City = "Versailles", ZipCode = "78000", Country = "France", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 18, FullName = "Diego Roel", Address = "C/ Moralzarzal, 86", City = "Madrid", ZipCode = "28034", Country = "Spain", Image = "/UserImages/image-9.jpg" },
                new User { UserId = 19, FullName = "Dominique Perrier", Address = "25, rue Lauriston", City = "Paris", ZipCode = "75016", Country = "France", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 20, FullName = "Eduardo Saavedra", Address = "Rambla de Catalu�a, 23", City = "Barcelona", ZipCode = "08022", Country = "Spain", Image = "/UserImages/image-10.jpg" },
                new User { UserId = 21, FullName = "Elizabeth Brown", Address = "Berkeley Gardens 12  Brewery", City = "London", ZipCode = "WX1 6LT", Country = "UK", Image = "/UserImages/image-7.jpg" },
                new User { UserId = 22, FullName = "Elizabeth Lincoln", Address = "23 Tsawassen Blvd.", City = "Tsawassen", ZipCode = "T2F 8M4", Country = "Canada", Image = "/UserImages/image-2.jpg" },
                new User { UserId = 23, FullName = "Felipe Izquierdo", Address = "Ave. 5 de Mayo Porlamar", City = "I. de Margarita", ZipCode = "4980", Country = "Venezuela", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 24, FullName = "Fran Wilson", Address = "89 Chiaroscuro Rd.", City = "Portland", ZipCode = "97219", Country = "USA", Image = "/UserImages/image-8.jpg" },
                new User { UserId = 25, FullName = "Francisco Chang", Address = "Sierras de Granada 9993", City = "M�xico D.F.", ZipCode = "05022", Country = "Mexico", Image = "/UserImages/image-5.jpg" },
                new User { UserId = 26, FullName = "Fr�d�rique Citeaux", Address = "24, place Kl�ber", City = "Strasbourg", ZipCode = "67000", Country = "France", Image = "/UserImages/image-2.jpg" },
                new User { UserId = 27, FullName = "Georg Pipps", Address = "Geislweg 14", City = "Salzburg", ZipCode = "5020", Country = "Austria", Image = "/UserImages/image-9.jpg" },
                new User { UserId = 28, FullName = "Giovanni Rovelli", Address = "Via Ludovico il Moro 22", City = "Bergamo", ZipCode = "24100", Country = "Italy", Image = "/UserImages/image-7.jpg" },
                new User { UserId = 29, FullName = "Guillermo Fern�ndez", Address = "Calle Dr. Jorge Cash 321", City = "M�xico D.F.", ZipCode = "05033", Country = "Mexico", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 30, FullName = "Hanna Moos", Address = "Forsterstr. 57", City = "Mannheim", ZipCode = "68306", Country = "Germany", Image = "/UserImages/image-10.jpg" },
                new User { UserId = 31, FullName = "Hari Kumar", Address = "90 Wadhurst Rd.", City = "London", ZipCode = "OX15 4NB", Country = "UK", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 32, FullName = "Helen Bennett", Address = "Garden House Crowther Way", City = "Cowes", ZipCode = "PO31 7PJ", Country = "UK", Image = "/UserImages/image-8.jpg" },
                new User { UserId = 33, FullName = "Helvetius Nagy", Address = "722 DaVinci Blvd.", City = "Kirkland", ZipCode = "98034", Country = "USA", Image = "/UserImages/image-3.jpg" },
                new User { UserId = 34, FullName = "Henriette Pfalzheim", Address = "Mehrheimerstr. 369", City = "K�ln", ZipCode = "50739", Country = "Germany", Image = "/UserImages/image-2.jpg" },
                new User { UserId = 35, FullName = "Horst Kloss", Address = "Taucherstra�e 10", City = "Cunewalde", ZipCode = "01307", Country = "Germany", Image = "/UserImages/image-7.jpg" },
                new User { UserId = 36, FullName = "Howard Snyder", Address = "2732 Baker Blvd.", City = "Eugene", ZipCode = "97403", Country = "USA", Image = "/UserImages/image-9.jpg" },
                new User { UserId = 37, FullName = "Isabel de Castro", Address = "Estrada da sa�de n. 58", City = "Lisboa", ZipCode = "1756", Country = "Portugal", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 38, FullName = "Jaime Yorres", Address = "87 Polk St. Suite 5", City = "San Francisco", ZipCode = "94117", Country = "USA", Image = "/UserImages/image-2.jpg" },
                new User { UserId = 39, FullName = "Janete Limeira", Address = "Av. Copacabana, 267", City = "Rio de Janeiro", ZipCode = "02389-890", Country = "Brazil", Image = "/UserImages/image-3.jpg" },
                new User { UserId = 40, FullName = "Janine Labrune", Address = "67, rue des Cinquante Otages", City = "Nantes", ZipCode = "44000", Country = "France", Image = "/UserImages/image-10.jpg" },
                new User { UserId = 41, FullName = "Jean Fresni�re", Address = "43 rue St. Laurent", City = "Montr�al", ZipCode = "H1J 1C3", Country = "Canada", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 42, FullName = "John Steel", Address = "12 Orchestra Terrace", City = "Walla Walla", ZipCode = "99362", Country = "USA", Image = "/UserImages/image-7.jpg" },
                new User { UserId = 43, FullName = "Jonas Bergulfsen", Address = "Erling Skakkes gate 78", City = "Stavern", ZipCode = "4110", Country = "Norway", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 44, FullName = "Jose Pavarotti", Address = "187 Suffolk Ln.", City = "Boise", ZipCode = "83720", Country = "USA", Image = "/UserImages/image-4.jpg" },
                new User { UserId = 45, FullName = "Jos� Pedro Freyre", Address = "C/ Romero, 33", City = "Sevilla", ZipCode = "41101", Country = "Spain", Image = "/UserImages/image-9.jpg" },
                new User { UserId = 46, FullName = "Jytte Petersen", Address = "Vinb�ltet 34", City = "Kobenhavn", ZipCode = "1734", Country = "Denmark", Image = "/UserImages/image-2.jpg" },
                new User { UserId = 47, FullName = "Karin Josephs", Address = "Luisenstr. 48", City = "M�nster", ZipCode = "44087", Country = "Germany", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 48, FullName = "Karl Jablonski", Address = "305 - 14th Ave. S. Suite 3B", City = "Seattle", ZipCode = "98128", Country = "USA", Image = "/UserImages/image-8.jpg" },
                new User { UserId = 49, FullName = "Laurence Lebihan", Address = "12, rue des Bouchers", City = "Marseille", ZipCode = "13008", Country = "France", Image = "/UserImages/image-7.jpg" },
                new User { UserId = 50, FullName = "Lino Rodriguez", Address = "Jardim das rosas n. 32", City = "Lisboa", ZipCode = "1675", Country = "Portugal", Image = "/UserImages/image-10.jpg" },
                new User { UserId = 51, FullName = "Liu Wong", Address = "55 Grizzly Peak Rd.", City = "Butte", ZipCode = "59801", Country = "USA", Image = "/UserImages/image-3.jpg" },
                new User { UserId = 52, FullName = "Liz Nixon", Address = "89 Jefferson Way Suite 2", City = "Portland", ZipCode = "97201", Country = "USA", Image = "/UserImages/image-4.jpg" },
                new User { UserId = 53, FullName = "L�cia Carvalho", Address = "Alameda dos Can�rios, 891", City = "Sao Paulo", ZipCode = "05487-020", Country = "Brazil", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 54, FullName = "Manuel Pereira", Address = "5� Ave. Los Palos Grandes", City = "Caracas", ZipCode = "1081", Country = "Venezuela", Image = "/UserImages/image-9.jpg" },
                new User { UserId = 55, FullName = "Maria Anders", Address = "Obere Str. 57", City = "Berlin", ZipCode = "12209", Country = "Germany", Image = "/UserImages/image-5.jpg" },
                new User { UserId = 56, FullName = "Maria Larsson", Address = "�kergatan 24", City = "Br�cke", ZipCode = "S-844 67", Country = "Sweden", Image = "/UserImages/image-8.jpg" },
                new User { UserId = 57, FullName = "Marie Bertrand", Address = "265, boulevard Charonne", City = "Paris", ZipCode = "75012", Country = "France", Image = "/UserImages/image-3.jpg" },
                new User { UserId = 58, FullName = "Mario Pontes", Address = "Rua do Pa�o, 67", City = "Rio de Janeiro", ZipCode = "05454-876", Country = "Brazil", Image = "/UserImages/image-2.jpg" },
                new User { UserId = 59, FullName = "Mart�n Sommer", Address = "C/ Araquil, 67", City = "Madrid", ZipCode = "28023", Country = "Spain", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 60, FullName = "Martine Ranc�", Address = "184, chauss�e de Tournai", City = "Lille", ZipCode = "59000", Country = "France", Image = "/UserImages/image-10.jpg" },
                new User { UserId = 61, FullName = "Mary Saveley", Address = "2, rue du Commerce", City = "Lyon", ZipCode = "69004", Country = "France", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 62, FullName = "Matti Karttunen", Address = "Keskuskatu 45", City = "Helsinki", ZipCode = "21240", Country = "Finland", Image = "/UserImages/image-2.jpg" },
                new User { UserId = 63, FullName = "Maurizio Moroni", Address = "Strada Provinciale 124", City = "Reggio Emilia", ZipCode = "42100", Country = "Italy", Image = "/UserImages/image-9.jpg" },
                new User { UserId = 64, FullName = "Michael Holz", Address = "Grenzacherweg 237", City = "Gen�ve", ZipCode = "1203", Country = "Switzerland", Image = "/UserImages/image-8.jpg" },
                new User { UserId = 65, FullName = "Miguel Angel Paolino", Address = "Avda. Azteca 123", City = "M�xico D.F.", ZipCode = "05033", Country = "Mexico", Image = "/UserImages/image-5.jpg" },
                new User { UserId = 66, FullName = "Palle Ibsen", Address = "Smagsloget 45", City = "�rhus", ZipCode = "8200", Country = "Denmark", Image = "/UserImages/image-6.jpg" },
                new User { UserId = 67, FullName = "Paolo Accorti", Address = "Via Monte Bianco 34", City = "Torino", ZipCode = "10100", Country = "Italy", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 68, FullName = "Pascale Cartrain", Address = "Boulevard Tirou, 255", City = "Charleroi", ZipCode = "B-6000", Country = "Belgium", Image = "/UserImages/image-4.jpg" },
                new User { UserId = 69, FullName = "Patricio Simpson", Address = "Cerrito 333", City = "Buenos Aires", ZipCode = "1010", Country = "Argentina", Image = "/UserImages/image-3.jpg" },
                new User { UserId = 70, FullName = "Paul Henriot", Address = "59 rue de l'Abbaye", City = "Reims", ZipCode = "51100", Country = "France", Image = "/UserImages/image-10.jpg" },
                new User { UserId = 71, FullName = "Paula Parente", Address = "Rua do Mercado, 12", City = "Resende", ZipCode = "08737-363", Country = "Brazil", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 72, FullName = "Paula Wilson", Address = "2817 Milton Dr.", City = "Albuquerque", ZipCode = "87110", Country = "USA", Image = "/UserImages/image-9.jpg" },
                new User { UserId = 73, FullName = "Pedro Afonso", Address = "Av. dos Lus�adas, 23", City = "Sao Paulo", ZipCode = "05432-043", Country = "Brazil", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 74, FullName = "Peter Franken", Address = "Berliner Platz 43", City = "M�nchen", ZipCode = "80805", Country = "Germany", Image = "/UserImages/image-2.jpg" },
                new User { UserId = 75, FullName = "Philip Cramer", Address = "Maubelstr. 90", City = "Brandenburg", ZipCode = "14776", Country = "Germany", Image = "/UserImages/image-5.jpg" },
                new User { UserId = 76, FullName = "Pirkko Koskitalo", Address = "Torikatu 38", City = "Oulu", ZipCode = "90110", Country = "Finland", Image = "/UserImages/image-4.jpg" },
                new User { UserId = 77, FullName = "Renate Messner", Address = "Magazinweg 7", City = "Frankfurt a.M.", ZipCode = "60528", Country = "Germany", Image = "/UserImages/image-7.jpg" },
                new User { UserId = 78, FullName = "Rene Phillips", Address = "2743 Bering St.", City = "Anchorage", ZipCode = "99508", Country = "USA", Image = "/UserImages/image-6.jpg" },
                new User { UserId = 79, FullName = "Rita M�ller", Address = "Adenauerallee 900", City = "Stuttgart", ZipCode = "70563", Country = "Germany", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 80, FullName = "Roland Mendel", Address = "Kirchgasse 6", City = "Graz", ZipCode = "8010", Country = "Austria", Image = "/UserImages/image-10.jpg" },
                new User { UserId = 81, FullName = "Sergio Guti�rrez", Address = "Av. del Libertador 900", City = "Buenos Aires", ZipCode = "1010", Country = "Argentina", Image = "/UserImages/image-9.jpg" },
                new User { UserId = 82, FullName = "Simon Crowther", Address = "South House 300 Queensbridge", City = "London", ZipCode = "SW7 1RZ", Country = "UK", Image = "/UserImages/image-2.jpg" },
                new User { UserId = 83, FullName = "Sven Ottlieb", Address = "Walserweg 21", City = "Aachen", ZipCode = "52066", Country = "Germany", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 84, FullName = "Thomas Hardy", Address = "120 Hanover Sq.", City = "London", ZipCode = "WA1 1DP", Country = "UK", Image = "/UserImages/image-7.jpg" },
                new User { UserId = 85, FullName = "Victoria Ashworth", Address = "Fauntleroy Circus", City = "London", ZipCode = "EC2 5NT", Country = "UK", Image = "/UserImages/image-5.jpg" },
                new User { UserId = 86, FullName = "Yang Wang", Address = "Hauptstr. 29", City = "Bern", ZipCode = "3012", Country = "Switzerland", Image = "/UserImages/image-2.jpg" },
                new User { UserId = 87, FullName = "Yoshi Latimer", Address = "City Center Plaza 516 Main St.", City = "Elgin", ZipCode = "97827", Country = "USA", Image = "/UserImages/image-3.jpg" },
                new User { UserId = 88, FullName = "Yoshi Tannamuri", Address = "1900 Oak St.", City = "Vancouver", ZipCode = "V3F 2K1", Country = "Canada", Image = "/UserImages/image-8.jpg" },
                new User { UserId = 89, FullName = "Yvonne Moncada", Address = "Ing. Gustavo Moncada 8585 Piso 20-A", City = "Buenos Aires", ZipCode = "1010", Country = "Argentina", Image = "/UserImages/image-1.jpg" },
                new User { UserId = 90, FullName = "Zbyszek Piestrzeniewicz", Address = "ul. Filtrowa 68", City = "Warszawa", ZipCode = "01-012", Country = "Poland", Image = "/UserImages/image-10.jpg" }
            };

            Users.ForEach(s => context.Users.AddOrUpdate(p => p.FullName, s));
            context.SaveChanges();

            var contacts = new List<Contact>
            {
                new Contact  {ContactId =1, UserId =1,Mobile="", WorkPhone ="(953) 10956", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =2, UserId =2,Mobile="", WorkPhone ="(98) 598 76 54", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =3, UserId =3,Mobile="", WorkPhone ="(0)2-953010", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =4, UserId =4,Mobile="", WorkPhone ="(11) 555 4640", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =5, UserId =5,Mobile="", WorkPhone ="555-8787", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =6, UserId =6,Mobile="", WorkPhone ="(514) 555-2955", HomePhone="(514) 555-2921", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =7, UserId =7,Mobile="", WorkPhone ="(171) 555-2222", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =8, UserId =8,Mobile="", WorkPhone ="(503) 555-9931", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =9, UserId =9,Mobile="", WorkPhone ="(12345) 1212", HomePhone="(12345) 1210", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =10, UserId =10,Mobile="",WorkPhone ="38.76.98.06", HomePhone="38.76.98.58", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =11, UserId =11,Mobile="", WorkPhone ="(0544) 60323", HomePhone="(0544) 60603", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =12, UserId =12,Mobile="", WorkPhone ="(089) 6547665", HomePhone="(089) 6547667", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =13, UserId =13,Mobile="", WorkPhone ="(1) 03.83.00.68", HomePhone="(1) 03.83.00.62", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =14, UserId =14,Mobile="", WorkPhone ="(03) 444-2343", HomePhone="(03) 444-6588", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =15, UserId =15,Mobile="", WorkPhone ="(514) 555-9022", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =16, UserId =16,Mobile="", WorkPhone ="031-987 65 43", HomePhone="031-987 65 91", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =17, UserId =17,Mobile="", WorkPhone ="85.57.00.07", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =18, UserId =18,Mobile="", WorkPhone ="(069) 992755", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =19, UserId =19,Mobile="", WorkPhone ="(06) 431-7877", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =20, UserId =20,Mobile="", WorkPhone ="08-123 45 67", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =21, UserId =21,Mobile="", WorkPhone ="43844108", HomePhone="43844115", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =22, UserId =22,Mobile="", WorkPhone ="(161) 555-4448", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =23, UserId =23,Mobile="", WorkPhone ="(010) 9984510", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =24, UserId =24,Mobile="", WorkPhone ="(313) 555-5735", HomePhone="(313) 555-3349", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =25, UserId =25,Mobile="", WorkPhone ="(617) 555-3267", HomePhone="(617) 555-3389", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =26, UserId =26,Mobile="", WorkPhone ="(100) 555-4822", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =27, UserId =27,Mobile="", WorkPhone ="(04721) 8713", HomePhone="(04721) 8714", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =28, UserId =28,Mobile="", WorkPhone ="(02) 555-5914", HomePhone="(02) 555-4873", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =29, UserId =29,Mobile="", WorkPhone ="(03) 3555-5011", HomePhone="", WorkEmail="someWorkEmail@hotmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =30, UserId =3,Mobile="", WorkPhone ="(953) 10956", HomePhone="", WorkEmail="AnaTrujillo@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =31, UserId =3,Mobile="", WorkPhone ="555-8787", HomePhone="", WorkEmail="AnaTrujillo@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =32, UserId =4,Mobile="", WorkPhone ="555-8787", HomePhone="", WorkEmail="AnabelaDomingues@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =33, UserId =4,Mobile="", WorkPhone ="(0544) 60323", HomePhone="(0544) 60603", WorkEmail="AnabelaDomingues@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =34, UserId =5,Mobile="", WorkPhone ="555-8787", HomePhone="", WorkEmail="Andr�Fonseca@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =35, UserId =5,Mobile="", WorkPhone ="(0544) 60323", HomePhone="(0544) 60603", WorkEmail="Andr�Fonseca@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =36, UserId =6,Mobile="", WorkPhone ="(514) 555-9022", HomePhone="", WorkEmail="AnnDevon@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =37, UserId =6,Mobile="", WorkPhone ="(010) 9984510", HomePhone="", WorkEmail="AriaCruz@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =38, UserId =6,Mobile="", WorkPhone ="85.57.00.07", HomePhone="", WorkEmail="AriaCruz@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =39, UserId =6,Mobile="", WorkPhone ="(010) 9984510", HomePhone="", WorkEmail="AriaCruz@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =40, UserId =11,Mobile="", WorkPhone ="85.57.00.07", HomePhone="", WorkEmail="BernardoBatista@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =41, UserId =11,Mobile="", WorkPhone ="(010) 9984510", HomePhone="", WorkEmail="BernardoBatista@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =42, UserId =7,Mobile="", WorkPhone ="85.57.00.07", HomePhone="", WorkEmail="AnnetteRoulet@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =43, UserId =7,Mobile="", WorkPhone ="(010) 9984510", HomePhone="", WorkEmail="AnnetteRoulet@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =44, UserId =7,Mobile="", WorkPhone ="(12345) 1212", HomePhone="(12345) 1210", WorkEmail="AnnetteRoulet@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"},
                new Contact  {ContactId =45, UserId =7,Mobile="", WorkPhone ="43844108", HomePhone="43844115", WorkEmail="AnnetteRoulet@gmail.com",PersonalEmail="someWorkEmail@hotmail.com"}
            };

            contacts.ForEach(s => context.Contacts.AddOrUpdate(p => p.UserId, s));
            context.SaveChanges();

        }
    }
}
