using System;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System.Threading.Tasks;

using mrsProject.DAL;
using mrsProject.Models;
using System.Collections.Generic;

namespace mrsProject.Seeding
{
    //add identity data
    public static class SeedIdentity
    {
        public static async Task AddAdmin(IServiceProvider serviceProvider)
        {
            AppDbContext _db = serviceProvider.GetRequiredService<AppDbContext>();
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();


            //if role doesn't exist, add it
            if (await _roleManager.RoleExistsAsync("Manager") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Manager"));
            }

            if (await _roleManager.RoleExistsAsync("Customer") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Customer"));
            }

            if (await _roleManager.RoleExistsAsync("Employee") == false)
            {
                await _roleManager.CreateAsync(new IdentityRole("Employee"));
            }

            List<AppUser> Employees = new List<AppUser>();

            AppUser e1 = new AppUser();
            e1.SeedPassword = "dewey4";
            e1.LastName = "Baker";
            e1.FirstName = "Christopher";
            e1.Address = "1245 Lake Libris Dr.";
            e1.City = "Cedar Park";
            e1.State = "TX";
            e1.Zipcode = "78613";
            e1.Email = "c.baker@bevosbooks.com";
            e1.PhoneNumber = "3395325649";
            e1.TempRole = "Manager";
            Employees.Add(e1);

            AppUser e2 = new AppUser();
            e2.SeedPassword = "smitty";
            e2.LastName = "Barnes";
            e2.FirstName = "Susan";
            e2.Address = "888 S. Main";
            e2.City = "Kyle";
            e2.State = "TX";
            e2.Zipcode = "78640";
            e2.Email = "s.barnes@bevosbooks.com";
            e2.PhoneNumber = "9636389416";
            e2.TempRole = "Employee";
            Employees.Add(e2);

            AppUser e3 = new AppUser();
            e3.SeedPassword = "squirrel";
            e3.LastName = "Garcia";
            e3.FirstName = "Hector";
            e3.Address = "777 PBR Drive";
            e3.City = "Austin";
            e3.State = "TX";
            e3.Zipcode = "78712";
            e3.Email = "h.garcia@bevosbooks.com";
            e3.PhoneNumber = "4547135738";
            e3.TempRole = "Employee";
            Employees.Add(e3);

            AppUser e4 = new AppUser();
            e4.SeedPassword = "changalang";
            e4.LastName = "Ingram";
            e4.FirstName = "Brad";
            e4.Address = "6548 La Posada Ct.";
            e4.City = "Austin";
            e4.State = "TX";
            e4.Zipcode = "78705";
            e4.Email = "b.ingram@bevosbooks.com";
            e4.PhoneNumber = "5817343315";
            e4.TempRole = "Employee";
            Employees.Add(e4);

            AppUser e5 = new AppUser();
            e5.SeedPassword = "rhythm";
            e5.LastName = "Jackson";
            e5.FirstName = "Jack";
            e5.Address = "222 Main";
            e5.City = "Austin";
            e5.State = "TX";
            e5.Zipcode = "78760";
            e5.Email = "j.jackson@bevosbooks.com";
            e5.PhoneNumber = "8241915317";
            e5.TempRole = "Employee";
            Employees.Add(e5);

            AppUser e6 = new AppUser();
            e6.SeedPassword = "approval";
            e6.LastName = "Jacobs";
            e6.FirstName = "Todd";
            e6.Address = "4564 Elm St.";
            e6.City = "Georgetown";
            e6.State = "TX";
            e6.Zipcode = "78628";
            e6.Email = "t.jacobs@bevosbooks.com";
            e6.PhoneNumber = "2477822475";
            e6.TempRole = "Employee";
            Employees.Add(e6);

            AppUser e7 = new AppUser();
            e7.SeedPassword = "society";
            e7.LastName = "Jones";
            e7.FirstName = "Lester";
            e7.Address = "999 LeBlat";
            e7.City = "Austin";
            e7.State = "TX";
            e7.Zipcode = "78747";
            e7.Email = "l.jones@bevosbooks.com";
            e7.PhoneNumber = "4764966462";
            e7.TempRole = "Employee";
            Employees.Add(e7);

            AppUser e8 = new AppUser();
            e8.SeedPassword = "tanman";
            e8.LastName = "Larson";
            e8.FirstName = "Bill";
            e8.Address = "1212 N. First Ave";
            e8.City = "Round Rock";
            e8.State = "TX";
            e8.Zipcode = "78665";
            e8.Email = "b.larson@bevosbooks.com";
            e8.PhoneNumber = "3355258855";
            e8.TempRole = "Employee";
            Employees.Add(e8);

            AppUser e9 = new AppUser();
            e9.SeedPassword = "longhorns";
            e9.LastName = "Lawrence";
            e9.FirstName = "Victoria";
            e9.Address = "6639 Bookworm Ln.";
            e9.City = "Austin";
            e9.State = "TX";
            e9.Zipcode = "78712";
            e9.Email = "v.lawrence@bevosbooks.com";
            e9.PhoneNumber = "7511273054";
            e9.TempRole = "Employee";
            Employees.Add(e9);

            AppUser e10 = new AppUser();
            e10.SeedPassword = "swansong";
            e10.LastName = "Lopez";
            e10.FirstName = "Marshall";
            e10.Address = "90 SW North St";
            e10.City = "Austin";
            e10.State = "TX";
            e10.Zipcode = "78729";
            e10.Email = "m.lopez@bevosbooks.com";
            e10.PhoneNumber = "7477907070";
            e10.TempRole = "Employee";
            Employees.Add(e10);

            AppUser e11 = new AppUser();
            e11.SeedPassword = "fungus";
            e11.LastName = "MacLeod";
            e11.FirstName = "Jennifer";
            e11.Address = "2504 Far West Blvd.";
            e11.City = "Austin";
            e11.State = "TX";
            e11.Zipcode = "78705";
            e11.Email = "j.macleod@bevosbooks.com";
            e11.PhoneNumber = "2621216845";
            e11.TempRole = "Employee";
            Employees.Add(e11);

            AppUser e12 = new AppUser();
            e12.SeedPassword = "median";
            e12.LastName = "Markham";
            e12.FirstName = "Elizabeth";
            e12.Address = "7861 Chevy Chase";
            e12.City = "Austin";
            e12.State = "TX";
            e12.Zipcode = "78785";
            e12.Email = "e.markham@bevosbooks.com";
            e12.PhoneNumber = "5028075807";
            e12.TempRole = "Employee";
            Employees.Add(e12);

            AppUser e13 = new AppUser();
            e13.SeedPassword = "decorate";
            e13.LastName = "Martinez";
            e13.FirstName = "Gregory";
            e13.Address = "8295 Sunset Blvd.";
            e13.City = "Austin";
            e13.State = "TX";
            e13.Zipcode = "78712";
            e13.Email = "g.martinez@bevosbooks.com";
            e13.PhoneNumber = "1994708542";
            e13.TempRole = "Employee";
            Employees.Add(e13);

            AppUser e14 = new AppUser();
            e14.SeedPassword = "rankmary";
            e14.LastName = "Mason";
            e14.FirstName = "Jack";
            e14.Address = "444 45th St";
            e14.City = "Austin";
            e14.State = "TX";
            e14.Zipcode = "78701";
            e14.Email = "j.mason@bevosbooks.com";
            e14.PhoneNumber = "1748136441";
            e14.TempRole = "Employee";
            Employees.Add(e14);

            AppUser e15 = new AppUser();
            e15.SeedPassword = "kindly";
            e15.LastName = "Miller";
            e15.FirstName = "Charles";
            e15.Address = "8962 Main St.";
            e15.City = "Austin";
            e15.State = "TX";
            e15.Zipcode = "78709";
            e15.Email = "c.miller@bevosbooks.com";
            e15.PhoneNumber = "8999319585";
            e15.TempRole = "Employee";
            Employees.Add(e15);

            AppUser e16 = new AppUser();
            e16.SeedPassword = "ricearoni";
            e16.LastName = "Nguyen";
            e16.FirstName = "Mary";
            e16.Address = "465 N. Bear Cub";
            e16.City = "Austin";
            e16.State = "TX";
            e16.Zipcode = "78734";
            e16.Email = "m.nguyen@bevosbooks.com";
            e16.PhoneNumber = "8716746381";
            e16.TempRole = "Employee";
            Employees.Add(e16);

            AppUser e17 = new AppUser();
            e17.SeedPassword = "walkamile";
            e17.LastName = "Rankin";
            e17.FirstName = "Suzie";
            e17.Address = "23 Dewey Road";
            e17.City = "Austin";
            e17.State = "TX";
            e17.Zipcode = "78712";
            e17.Email = "s.rankin@bevosbooks.com";
            e17.PhoneNumber = "5239029525";
            e17.TempRole = "Employee";
            Employees.Add(e17);

            AppUser e18 = new AppUser();
            e18.SeedPassword = "ingram45";
            e18.LastName = "Rhodes";
            e18.FirstName = "Megan";
            e18.Address = "4587 Enfield Rd.";
            e18.City = "Austin";
            e18.State = "TX";
            e18.Zipcode = "78729";
            e18.Email = "m.rhodes@bevosbooks.com";
            e18.PhoneNumber = "1232139514";
            e18.TempRole = "Employee";
            Employees.Add(e18);

            AppUser e19 = new AppUser();
            e19.SeedPassword = "arched";
            e19.LastName = "Rice";
            e19.FirstName = "Eryn";
            e19.Address = "3405 Rio Grande";
            e19.City = "Austin";
            e19.State = "TX";
            e19.Zipcode = "78746";
            e19.Email = "e.rice@bevosbooks.com";
            e19.PhoneNumber = "2706602803";
            e19.TempRole = "Manager";
            Employees.Add(e19);

            AppUser e20 = new AppUser();
            e20.SeedPassword = "lottery";
            e20.LastName = "Rogers";
            e20.FirstName = "Allen";
            e20.Address = "4965 Oak Hill";
            e20.City = "Austin";
            e20.State = "TX";
            e20.Zipcode = "78705";
            e20.Email = "a.rogers@bevosbooks.com";
            e20.PhoneNumber = "4139645586";
            e20.TempRole = "Manager";
            Employees.Add(e20);

            AppUser e21 = new AppUser();
            e21.SeedPassword = "nostalgic";
            e21.LastName = "Saunders";
            e21.FirstName = "Sarah";
            e21.Address = "332 Avenue C";
            e21.City = "Austin";
            e21.State = "TX";
            e21.Zipcode = "78733";
            e21.Email = "s.saunders@bevosbooks.com";
            e21.PhoneNumber = "9036349587";
            e21.TempRole = "Employee";
            Employees.Add(e21);

            AppUser e22 = new AppUser();
            e22.SeedPassword = "offbeat";
            e22.LastName = "Sewell";
            e22.FirstName = "William";
            e22.Address = "2365 51st St.";
            e22.City = "Austin";
            e22.State = "TX";
            e22.Zipcode = "78755";
            e22.Email = "w.sewell@bevosbooks.com";
            e22.PhoneNumber = "7224308314";
            e22.TempRole = "Manager";
            Employees.Add(e22);

            AppUser e23 = new AppUser();
            e23.SeedPassword = "evanescent";
            e23.LastName = "Sheffield";
            e23.FirstName = "Martin";
            e23.Address = "3886 Avenue A";
            e23.City = "San Marcos";
            e23.State = "TX";
            e23.Zipcode = "78666";
            e23.Email = "m.sheffield@bevosbooks.com";
            e23.PhoneNumber = "9349192978";
            e23.TempRole = "Employee";
            Employees.Add(e23);

            AppUser e24 = new AppUser();
            e24.SeedPassword = "stewboy";
            e24.LastName = "Silva";
            e24.FirstName = "Cindy";
            e24.Address = "900 4th St";
            e24.City = "Austin";
            e24.State = "TX";
            e24.Zipcode = "78758";
            e24.Email = "c.silva@bevosbooks.com";
            e24.PhoneNumber = "4874328170";
            e24.TempRole = "Employee";
            Employees.Add(e24);

            AppUser e25 = new AppUser();
            e25.SeedPassword = "instrument";
            e25.LastName = "Stuart";
            e25.FirstName = "Eric";
            e25.Address = "5576 Toro Ring";
            e25.City = "Austin";
            e25.State = "TX";
            e25.Zipcode = "78758";
            e25.Email = "e.stuart@bevosbooks.com";
            e25.PhoneNumber = "1967846827";
            e25.TempRole = "Employee";
            Employees.Add(e25);

            AppUser e26 = new AppUser();
            e26.SeedPassword = "hecktour";
            e26.LastName = "Tanner";
            e26.FirstName = "Jeremy";
            e26.Address = "4347 Almstead";
            e26.City = "Austin";
            e26.State = "TX";
            e26.Zipcode = "78712";
            e26.Email = "j.tanner@bevosbooks.com";
            e26.PhoneNumber = "5923026779";
            e26.TempRole = "Employee";
            Employees.Add(e26);

            AppUser e27 = new AppUser();
            e27.SeedPassword = "countryrhodes";
            e27.LastName = "Taylor";
            e27.FirstName = "Allison";
            e27.Address = "467 Nueces St.";
            e27.City = "Austin";
            e27.State = "TX";
            e27.Zipcode = "78727";
            e27.Email = "a.taylor@bevosbooks.com";
            e27.PhoneNumber = "7246195827";
            e27.TempRole = "Employee";
            Employees.Add(e27);

            AppUser e28 = new AppUser();
            e28.SeedPassword = "landus";
            e28.LastName = "Taylor";
            e28.FirstName = "Rachel";
            e28.Address = "345 Longview Dr.";
            e28.City = "Austin";
            e28.State = "TX";
            e28.Zipcode = "78746";
            e28.Email = "r.taylor@bevosbooks.com";
            e28.PhoneNumber = "9071236087";
            e28.TempRole = "Manager";
            Employees.Add(e28);

            foreach (AppUser employee in Employees)
            {
                //see if book exists in database
                AppUser dbEmployee = _db.Users.FirstOrDefault(c => c.Email == employee.Email);

                if (dbEmployee == null) //repository does not exist in database
                {
                    dbEmployee = new AppUser();
                    dbEmployee.UserName = employee.Email;
                    dbEmployee.SeedPassword = employee.SeedPassword;
                    dbEmployee.LastName = employee.LastName;
                    dbEmployee.FirstName = employee.FirstName;
                    dbEmployee.Address = employee.Address;
                    dbEmployee.City = employee.City;
                    dbEmployee.State = employee.State;
                    dbEmployee.Zipcode = employee.Zipcode;
                    dbEmployee.Email = employee.Email;
                    dbEmployee.PhoneNumber = employee.PhoneNumber;

                    var result = await _userManager.CreateAsync(dbEmployee, dbEmployee.SeedPassword);
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }
                    _db.SaveChanges();
                    dbEmployee = _db.Users.FirstOrDefault(u => u.UserName == dbEmployee.UserName);
                }
                if (employee.TempRole == "Manager")
                {
                    if (await _userManager.IsInRoleAsync(dbEmployee, "Manager") == false)
                    {
                        await _userManager.AddToRoleAsync(dbEmployee, "Manager");
                    }
                }

                if (employee.TempRole == "Employee")
                {
                    if (await _userManager.IsInRoleAsync(dbEmployee, "Employee") == false)
                    {
                        await _userManager.AddToRoleAsync(dbEmployee, "Employee");
                    }
                }
                _db.SaveChanges();
            }










            List<AppUser> Customers = new List<AppUser>();

            AppUser c1 = new AppUser();
            c1.SeedPassword = "bookworm";
            c1.LastName = "Baker";
            c1.FirstName = "Christopher";
            c1.Address = "1898 Schurz Alley";
            c1.City = "Austin";
            c1.State = "TX";
            c1.Zipcode = "78705";
            c1.Email = "cbaker@example.com";
            c1.PhoneNumber = "5725458641";
            Customers.Add(c1);

            AppUser c2 = new AppUser();
            c2.SeedPassword = "potato";
            c2.LastName = "Banks";
            c2.FirstName = "Michelle";
            c2.Address = "97 Elmside Pass";
            c2.City = "Austin";
            c2.State = "TX";
            c2.Zipcode = "78712";
            c2.Email = "banker@longhorn.net";
            c2.PhoneNumber = "9867048435";
            Customers.Add(c2);

            AppUser c3 = new AppUser();
            c3.SeedPassword = "painting";
            c3.LastName = "Broccolo";
            c3.FirstName = "Franco";
            c3.Address = "88 Crowley Circle";
            c3.City = "Austin";
            c3.State = "TX";
            c3.Zipcode = "78786";
            c3.Email = "franco@example.com";
            c3.PhoneNumber = "6836109514";
            Customers.Add(c3);

            AppUser c4 = new AppUser();
            c4.SeedPassword = "texas1";
            c4.LastName = "Chang";
            c4.FirstName = "Wendy";
            c4.Address = "56560 Sage Junction";
            c4.City = "Eagle Pass";
            c4.State = "TX";
            c4.Zipcode = "78852";
            c4.Email = "wchang@example.com";
            c4.PhoneNumber = "7070911071";
            Customers.Add(c4);

            AppUser c5 = new AppUser();
            c5.SeedPassword = "Anchorage";
            c5.LastName = "Chou";
            c5.FirstName = "Lim";
            c5.Address = "60 Lunder Point";
            c5.City = "Austin";
            c5.State = "TX";
            c5.Zipcode = "78729";
            c5.Email = "limchou@gogle.com";
            c5.PhoneNumber = "1488907687";
            Customers.Add(c5);

            AppUser c6 = new AppUser();
            c6.SeedPassword = "aggies";
            c6.LastName = "Dixon";
            c6.FirstName = "Shan";
            c6.Address = "9448 Pleasure Avenue";
            c6.City = "Georgetown";
            c6.State = "TX";
            c6.Zipcode = "78628";
            c6.Email = "shdixon@aoll.com";
            c6.PhoneNumber = "6899701824";
            Customers.Add(c6);

            AppUser c7 = new AppUser();
            c7.SeedPassword = "hampton1";
            c7.LastName = "Evans";
            c7.FirstName = "Jim Bob";
            c7.Address = "51 Emmet Parkway";
            c7.City = "Austin";
            c7.State = "TX";
            c7.Zipcode = "78705";
            c7.Email = "j.b.evans@aheca.org";
            c7.PhoneNumber = "9986825917";
            Customers.Add(c7);

            AppUser c8 = new AppUser();
            c8.SeedPassword = "longhorns";
            c8.LastName = "Feeley";
            c8.FirstName = "Lou Ann";
            c8.Address = "65 Darwin Crossing";
            c8.City = "Austin";
            c8.State = "TX";
            c8.Zipcode = "78704";
            c8.Email = "feeley@penguin.org";
            c8.PhoneNumber = "3464121966";
            Customers.Add(c8);

            AppUser c9 = new AppUser();
            c9.SeedPassword = "mustangs";
            c9.LastName = "Freeley";
            c9.FirstName = "Tesa";
            c9.Address = "7352 Loftsgordon Court";
            c9.City = "College Station";
            c9.State = "TX";
            c9.Zipcode = "77840";
            c9.Email = "tfreeley@minnetonka.ci.us";
            c9.PhoneNumber = "6581357270";
            Customers.Add(c9);

            AppUser c10 = new AppUser();
            c10.SeedPassword = "onetime";
            c10.LastName = "Garcia";
            c10.FirstName = "Margaret";
            c10.Address = "7 International Road";
            c10.City = "Austin";
            c10.State = "TX";
            c10.Zipcode = "78756";
            c10.Email = "mgarcia@gogle.com";
            c10.PhoneNumber = "3767347949";
            Customers.Add(c10);

            AppUser c11 = new AppUser();
            c11.SeedPassword = "pepperoni";
            c11.LastName = "Haley";
            c11.FirstName = "Charles";
            c11.Address = "8 Warrior Trail";
            c11.City = "Austin";
            c11.State = "TX";
            c11.Zipcode = "78746";
            c11.Email = "chaley@thug.com";
            c11.PhoneNumber = "2198604221";
            Customers.Add(c11);

            AppUser c12 = new AppUser();
            c12.SeedPassword = "raiders";
            c12.LastName = "Hampton";
            c12.FirstName = "Jeffrey";
            c12.Address = "9107 Lighthouse Bay Road";
            c12.City = "Austin";
            c12.State = "TX";
            c12.Zipcode = "78756";
            c12.Email = "jeffh@sonic.com";
            c12.PhoneNumber = "1222185888";
            Customers.Add(c12);

            AppUser c13 = new AppUser();
            c13.SeedPassword = "jhearn22";
            c13.LastName = "Hearn";
            c13.FirstName = "John";
            c13.Address = "59784 Pierstorff Center";
            c13.City = "Liberty";
            c13.State = "TX";
            c13.Zipcode = "77575";
            c13.Email = "wjhearniii@umich.org";
            c13.PhoneNumber = "5123071976";
            Customers.Add(c13);

            AppUser c14 = new AppUser();
            c14.SeedPassword = "hickhickup";
            c14.LastName = "Hicks";
            c14.FirstName = "Anthony";
            c14.Address = "932 Monica Way";
            c14.City = "San Antonio";
            c14.State = "TX";
            c14.Zipcode = "78203";
            c14.Email = "ahick@yaho.com";
            c14.PhoneNumber = "1211949601";
            Customers.Add(c14);

            AppUser c15 = new AppUser();
            c15.SeedPassword = "ingram2015";
            c15.LastName = "Ingram";
            c15.FirstName = "Brad";
            c15.Address = "4 Lukken Court";
            c15.City = "New Braunfels";
            c15.State = "TX";
            c15.Zipcode = "78132";
            c15.Email = "ingram@jack.com";
            c15.PhoneNumber = "1372121569";
            Customers.Add(c15);

            AppUser c16 = new AppUser();
            c16.SeedPassword = "toddy25";
            c16.LastName = "Jacobs";
            c16.FirstName = "Todd";
            c16.Address = "7 Susan Junction";
            c16.City = "New York";
            c16.State = "NY";
            c16.Zipcode = "10101";
            c16.Email = "toddj@yourmom.com";
            c16.PhoneNumber = "8543163836";
            Customers.Add(c16);

            AppUser c17 = new AppUser();
            c17.SeedPassword = "something";
            c17.LastName = "Lawrence";
            c17.FirstName = "Victoria";
            c17.Address = "669 Oak Junction";
            c17.City = "Lockhart";
            c17.State = "TX";
            c17.Zipcode = "78644";
            c17.Email = "thequeen@aska.net";
            c17.PhoneNumber = "3214163359";
            Customers.Add(c17);

            AppUser c18 = new AppUser();
            c18.SeedPassword = "Password1";
            c18.LastName = "Lineback";
            c18.FirstName = "Erik";
            c18.Address = "099 Luster Point";
            c18.City = "Kingwood";
            c18.State = "TX";
            c18.Zipcode = "77325";
            c18.Email = "linebacker@gogle.com";
            c18.PhoneNumber = "2505265350";
            Customers.Add(c18);

            AppUser c19 = new AppUser();
            c19.SeedPassword = "aclfest2017";
            c19.LastName = "Lowe";
            c19.FirstName = "Ernest";
            c19.Address = "35473 Hansons Hill";
            c19.City = "Beverly Hills";
            c19.State = "CA";
            c19.Zipcode = "90210";
            c19.Email = "elowe@netscare.net";
            c19.PhoneNumber = "4070619503";
            Customers.Add(c19);

            AppUser c20 = new AppUser();
            c20.SeedPassword = "nothinggood";
            c20.LastName = "Luce";
            c20.FirstName = "Chuck";
            c20.Address = "4 Emmet Junction";
            c20.City = "Navasota";
            c20.State = "TX";
            c20.Zipcode = "77868";
            c20.Email = "cluce@gogle.com";
            c20.PhoneNumber = "7358436110";
            Customers.Add(c20);

            AppUser c21 = new AppUser();
            c21.SeedPassword = "whatever";
            c21.LastName = "MacLeod";
            c21.FirstName = "Jennifer";
            c21.Address = "3 Orin Road";
            c21.City = "Austin";
            c21.State = "TX";
            c21.Zipcode = "78712";
            c21.Email = "mackcloud@george.com";
            c21.PhoneNumber = "7240178229";
            Customers.Add(c21);

            AppUser c22 = new AppUser();
            c22.SeedPassword = "snowsnow";
            c22.LastName = "Markham";
            c22.FirstName = "Elizabeth";
            c22.Address = "8171 Commercial Crossing";
            c22.City = "Austin";
            c22.State = "TX";
            c22.Zipcode = "78712";
            c22.Email = "cmartin@beets.com";
            c22.PhoneNumber = "2495200223";
            Customers.Add(c22);

            AppUser c23 = new AppUser();
            c23.SeedPassword = "whocares";
            c23.LastName = "Martin";
            c23.FirstName = "Clarence";
            c23.Address = "96 Anthes Place";
            c23.City = "Schenectady";
            c23.State = "NY";
            c23.Zipcode = "12345";
            c23.Email = "clarence@yoho.com";
            c23.PhoneNumber = "4086179161";
            Customers.Add(c23);

            AppUser c24 = new AppUser();
            c24.SeedPassword = "xcellent";
            c24.LastName = "Martinez";
            c24.FirstName = "Gregory";
            c24.Address = "10 Northridge Plaza";
            c24.City = "Austin";
            c24.State = "TX";
            c24.Zipcode = "78717";
            c24.Email = "gregmartinez@drdre.com";
            c24.PhoneNumber = "9371927523";
            Customers.Add(c24);

            AppUser c25 = new AppUser();
            c25.SeedPassword = "mydogspot";
            c25.LastName = "Miller";
            c25.FirstName = "Charles";
            c25.Address = "87683 Schmedeman Circle";
            c25.City = "Austin";
            c25.State = "TX";
            c25.Zipcode = "78727";
            c25.Email = "cmiller@bob.com";
            c25.PhoneNumber = "5954063857";
            Customers.Add(c25);

            AppUser c26 = new AppUser();
            c26.SeedPassword = "spotmydog";
            c26.LastName = "Nelson";
            c26.FirstName = "Kelly";
            c26.Address = "3244 Ludington Court";
            c26.City = "Beaumont";
            c26.State = "TX";
            c26.Zipcode = "77720";
            c26.Email = "knelson@aoll.com";
            c26.PhoneNumber = "8929209512";
            Customers.Add(c26);

            AppUser c27 = new AppUser();
            c27.SeedPassword = "joejoejoe";
            c27.LastName = "Nguyen";
            c27.FirstName = "Joe";
            c27.Address = "4780 Talisman Court";
            c27.City = "San Marcos";
            c27.State = "TX";
            c27.Zipcode = "78667";
            c27.Email = "joewin@xfactor.com";
            c27.PhoneNumber = "9226301774";
            Customers.Add(c27);

            AppUser c28 = new AppUser();
            c28.SeedPassword = "billyboy";
            c28.LastName = "O'Reilly";
            c28.FirstName = "Bill";
            c28.Address = "4154 Delladonna Plaza";
            c28.City = "Bergheim";
            c28.State = "TX";
            c28.Zipcode = "78004";
            c28.Email = "orielly@foxnews.cnn";
            c28.PhoneNumber = "2537646912";
            Customers.Add(c28);

            AppUser c29 = new AppUser();
            c29.SeedPassword = "radgirl";
            c29.LastName = "Radkovich";
            c29.FirstName = "Anka";
            c29.Address = "72361 Bayside Drive";
            c29.City = "Austin";
            c29.State = "TX";
            c29.Zipcode = "78789";
            c29.Email = "ankaisrad@gogle.com";
            c29.PhoneNumber = "2182889379";
            Customers.Add(c29);

            AppUser c30 = new AppUser();
            c30.SeedPassword = "meganr34";
            c30.LastName = "Rhodes";
            c30.FirstName = "Megan";
            c30.Address = "76875 Hoffman Point";
            c30.City = "Orlando";
            c30.State = "FL";
            c30.Zipcode = "32830";
            c30.Email = "megrhodes@freserve.co.uk";
            c30.PhoneNumber = "9532396075";
            Customers.Add(c30);

            AppUser c31 = new AppUser();
            c31.SeedPassword = "ricearoni";
            c31.LastName = "Rice";
            c31.FirstName = "Eryn";
            c31.Address = "048 Elmside Park";
            c31.City = "South Padre Island";
            c31.State = "TX";
            c31.Zipcode = "78597";
            c31.Email = "erynrice@aoll.com";
            c31.PhoneNumber = "7303815953";
            Customers.Add(c31);

            AppUser c32 = new AppUser();
            c32.SeedPassword = "alaskaboy";
            c32.LastName = "Rodriguez";
            c32.FirstName = "Jorge";
            c32.Address = "01 Browning Pass";
            c32.City = "Austin";
            c32.State = "TX";
            c32.Zipcode = "78744";
            c32.Email = "jorge@noclue.com";
            c32.PhoneNumber = "3677322422";
            Customers.Add(c32);

            AppUser c33 = new AppUser();
            c33.SeedPassword = "bunnyhop";
            c33.LastName = "Rogers";
            c33.FirstName = "Allen";
            c33.Address = "844 Anderson Alley";
            c33.City = "Canyon Lake";
            c33.State = "TX";
            c33.Zipcode = "78133";
            c33.Email = "mrrogers@lovelyday.com";
            c33.PhoneNumber = "3911705385";
            Customers.Add(c33);

            AppUser c34 = new AppUser();
            c34.SeedPassword = "dustydusty";
            c34.LastName = "Saint-Jean";
            c34.FirstName = "Olivier";
            c34.Address = "1891 Docker Point";
            c34.City = "Austin";
            c34.State = "TX";
            c34.Zipcode = "78779";
            c34.Email = "stjean@athome.com";
            c34.PhoneNumber = "7351610920";
            Customers.Add(c34);

            AppUser c35 = new AppUser();
            c35.SeedPassword = "jrod2017";
            c35.LastName = "Saunders";
            c35.FirstName = "Sarah";
            c35.Address = "1469 Upham Road";
            c35.City = "Austin";
            c35.State = "TX";
            c35.Zipcode = "78720";
            c35.Email = "saunders@pen.com";
            c35.PhoneNumber = "5269661692";
            Customers.Add(c35);

            AppUser c36 = new AppUser();
            c36.SeedPassword = "martin1234";
            c36.LastName = "Sewell";
            c36.FirstName = "William";
            c36.Address = "1672 Oak Valley Circle";
            c36.City = "Austin";
            c36.State = "TX";
            c36.Zipcode = "78705";
            c36.Email = "willsheff@email.com";
            c36.PhoneNumber = "1875727246";
            Customers.Add(c36);

            AppUser c37 = new AppUser();
            c37.SeedPassword = "penguin12";
            c37.LastName = "Sheffield";
            c37.FirstName = "Martin";
            c37.Address = "816 Kennedy Place";
            c37.City = "Round Rock";
            c37.State = "TX";
            c37.Zipcode = "78680";
            c37.Email = "sheffiled@gogle.com";
            c37.PhoneNumber = "1394323615";
            Customers.Add(c37);

            AppUser c38 = new AppUser();
            c38.SeedPassword = "rogerthat";
            c38.LastName = "Smith";
            c38.FirstName = "John";
            c38.Address = "0745 Golf Road";
            c38.City = "Austin";
            c38.State = "TX";
            c38.Zipcode = "78760";
            c38.Email = "johnsmith187@aoll.com";
            c38.PhoneNumber = "6645937874";
            Customers.Add(c38);

            AppUser c39 = new AppUser();
            c39.SeedPassword = "smitty444";
            c39.LastName = "Stroud";
            c39.FirstName = "Dustin";
            c39.Address = "505 Dexter Plaza";
            c39.City = "Sweet Home";
            c39.State = "TX";
            c39.Zipcode = "77987";
            c39.Email = "dustroud@mail.com";
            c39.PhoneNumber = "6470254680";
            Customers.Add(c39);

            AppUser c40 = new AppUser();
            c40.SeedPassword = "stewball";
            c40.LastName = "Stuart";
            c40.FirstName = "Eric";
            c40.Address = "585 Claremont Drive";
            c40.City = "Corpus Christi";
            c40.State = "TX";
            c40.Zipcode = "78412";
            c40.Email = "estuart@anchor.net";
            c40.PhoneNumber = "7701621022";
            Customers.Add(c40);

            AppUser c41 = new AppUser();
            c41.SeedPassword = "slowwind";
            c41.LastName = "Stump";
            c41.FirstName = "Peter";
            c41.Address = "89035 Welch Circle";
            c41.City = "Pflugerville";
            c41.State = "TX";
            c41.Zipcode = "78660";
            c41.Email = "peterstump@noclue.com";
            c41.PhoneNumber = "2181960061";
            Customers.Add(c41);

            AppUser c42 = new AppUser();
            c42.SeedPassword = "tanner5454";
            c42.LastName = "Tanner";
            c42.FirstName = "Jeremy";
            c42.Address = "4 Stang Trail";
            c42.City = "Austin";
            c42.State = "TX";
            c42.Zipcode = "78702";
            c42.Email = "jtanner@mustang.net";
            c42.PhoneNumber = "9908469499";
            Customers.Add(c42);

            AppUser c43 = new AppUser();
            c43.SeedPassword = "allyrally";
            c43.LastName = "Taylor";
            c43.FirstName = "Allison";
            c43.Address = "726 Twin Pines Avenue";
            c43.City = "Austin";
            c43.State = "TX";
            c43.Zipcode = "78713";
            c43.Email = "taylordjay@aoll.com";
            c43.PhoneNumber = "7011918647";
            Customers.Add(c43);

            AppUser c44 = new AppUser();
            c44.SeedPassword = "taylorbaylor";
            c44.LastName = "Taylor";
            c44.FirstName = "Rachel";
            c44.Address = "06605 Sugar Drive";
            c44.City = "Austin";
            c44.State = "TX";
            c44.Zipcode = "78712";
            c44.Email = "rtaylor@gogle.com";
            c44.PhoneNumber = "8937910053";
            Customers.Add(c44);

            AppUser c45 = new AppUser();
            c45.SeedPassword = "teeoff22";
            c45.LastName = "Tee";
            c45.FirstName = "Frank";
            c45.Address = "3567 Dawn Plaza";
            c45.City = "Austin";
            c45.State = "TX";
            c45.Zipcode = "78786";
            c45.Email = "teefrank@noclue.com";
            c45.PhoneNumber = "6394568913";
            Customers.Add(c45);

            AppUser c46 = new AppUser();
            c46.SeedPassword = "tucksack1";
            c46.LastName = "Tucker";
            c46.FirstName = "Clent";
            c46.Address = "704 Northland Alley";
            c46.City = "San Antonio";
            c46.State = "TX";
            c46.Zipcode = "78279";
            c46.Email = "ctucker@alphabet.co.uk";
            c46.PhoneNumber = "2676838676";
            Customers.Add(c46);

            AppUser c47 = new AppUser();
            c47.SeedPassword = "meow88";
            c47.LastName = "Velasco";
            c47.FirstName = "Allen";
            c47.Address = "72 Harbort Point";
            c47.City = "Navasota";
            c47.State = "TX";
            c47.Zipcode = "77868";
            c47.Email = "avelasco@yoho.com";
            c47.PhoneNumber = "3452909754";
            Customers.Add(c47);

            AppUser c48 = new AppUser();
            c48.SeedPassword = "vinovino";
            c48.LastName = "Vino";
            c48.FirstName = "Janet";
            c48.Address = "1 Oak Valley Place";
            c48.City = "Boston";
            c48.State = "MA";
            c48.Zipcode = "02114";
            c48.Email = "vinovino@grapes.com";
            c48.PhoneNumber = "8567089194";
            Customers.Add(c48);

            AppUser c49 = new AppUser();
            c49.SeedPassword = "gowest";
            c49.LastName = "West";
            c49.FirstName = "Jake";
            c49.Address = "48743 Banding Parkway";
            c49.City = "Marble Falls";
            c49.State = "TX";
            c49.Zipcode = "78654";
            c49.Email = "westj@pioneer.net";
            c49.PhoneNumber = "6260784394";
            Customers.Add(c49);

            AppUser c50 = new AppUser();
            c50.SeedPassword = "louielouie";
            c50.LastName = "Winthorpe";
            c50.FirstName = "Louis";
            c50.Address = "96850 Summit Crossing";
            c50.City = "Austin";
            c50.State = "TX";
            c50.Zipcode = "78730";
            c50.Email = "winner@hootmail.com";
            c50.PhoneNumber = "3733971174";
            Customers.Add(c50);

            AppUser c51 = new AppUser();
            c51.SeedPassword = "woodyman1";
            c51.LastName = "Wood";
            c51.FirstName = "Reagan";
            c51.Address = "18354 Bluejay Street";
            c51.City = "Austin";
            c51.State = "TX";
            c51.Zipcode = "78712";
            c51.Email = "rwood@voyager.net";
            c51.PhoneNumber = "8433359800";
            Customers.Add(c51);

            foreach (AppUser customer in Customers)
            {
                AppUser cust = _db.Users.FirstOrDefault(u => u.Email == customer.Email);

                if (cust == null)
                {
                    cust = new AppUser();

                    cust.UserName = customer.Email;
                    cust.SeedPassword = customer.SeedPassword;
                    cust.LastName = customer.LastName;
                    cust.FirstName = customer.FirstName;
                    cust.Address = customer.Address;
                    cust.City = customer.City;
                    cust.State = customer.State;
                    cust.Zipcode = customer.Zipcode;
                    cust.Email = customer.Email;
                    cust.PhoneNumber = customer.PhoneNumber;

                    var result = await _userManager.CreateAsync(cust, cust.SeedPassword);
                    if (result.Succeeded == false)
                    {
                        throw new Exception("This user can't be added - " + result.ToString());
                    }
                    _db.SaveChanges();
                    cust = _db.Users.FirstOrDefault(u => u.UserName == cust.UserName);
                }

                if (await _userManager.IsInRoleAsync(cust, "Customer") == false)
                {
                    await _userManager.AddToRoleAsync(cust, "Customer");
                }

                _db.SaveChanges();
            }
        //    //check to see if the manager has been added
        //    AppUser manager = _db.Users.FirstOrDefault(u => u.Email == "admin@example.com");

        //    //if manager hasn't been created, then add them
        //    if (manager == null)
        //    {
        //        manager = new AppUser();
        //        manager.UserName = "admin@example.com";
        //        manager.Email = "admin@example.com";
        //        manager.PhoneNumber = "(512)555-5555";
        //        manager.FirstName = "Admin";
        //        manager.LastName = "Example";


        //        //NOTE: Ask the user manager to create the new user
        //        //The second parameter for .CreateAsync is the user's password
        //        var result = await _userManager.CreateAsync(manager, "Abc123!");
        //        if (result.Succeeded == false)
        //        {
        //            throw new Exception("This user can't be added - " + result.ToString());
        //        }
        //        _db.SaveChanges();
        //        manager = _db.Users.FirstOrDefault(u => u.UserName == "admin@example.com");
        //    }

        //    //make sure user is in role
        //    if (await _userManager.IsInRoleAsync(manager, "Manager") == false)
        //    {
        //        await _userManager.AddToRoleAsync(manager, "Manager");
        //    }

        //    //save changes
        //    _db.SaveChanges();

        }
    }
}