using mrsProject.Models;
using mrsProject.DAL;
using System.Collections.Generic;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

namespace mrsProject.Seeding
{
	public static class SeedEmployees
	{
		public static async Task SeedAllCustomers(AppDbContext db, IServiceProvider serviceProvider)
		{
            UserManager<AppUser> _userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            RoleManager<IdentityRole> _roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();


            Int32 intEmployeesAdded = 0;
			String employeeName = "Begin"; //helps to keep track of error on repos
			List<AppUser> Employees = new List<AppUser>();

			try
			{
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

				//loop through books
				foreach (AppUser employee in Employees)
				{
					//set name of customer to help debug
					employeeName = employee.Email;

					//see if book exists in database
					AppUser dbEmployee = db.Users.FirstOrDefault(c => c.Email == employee.Email);

					if (dbEmployee == null) //repository does not exist in database
					{
						db.Users.Add(employee);
						db.SaveChanges();
						intEmployeesAdded += 1;
					}
					else
					{
						dbEmployee.SeedPassword = employee.SeedPassword;
						dbEmployee.LastName = employee.LastName;
						dbEmployee.FirstName = employee.FirstName;
						dbEmployee.Address = employee.Address;
						dbEmployee.City = employee.City;
						dbEmployee.State = employee.State;
						dbEmployee.Zipcode = employee.Zipcode;
						dbEmployee.Email = employee.Email;
						dbEmployee.PhoneNumber = employee.PhoneNumber;


                        if (employee.TempRole == "Manager")
                        {
                            var result = await _userManager.CreateAsync(dbEmployee, dbEmployee.SeedPassword);
                            if (result.Succeeded == false)
                            {
                                throw new Exception("This user can't be added - " + result.ToString());
                            }

                            if (await _userManager.IsInRoleAsync(dbEmployee, "Manager") == false)
                            {
                                await _userManager.AddToRoleAsync(dbEmployee, "Manager");
                            }
                        }

                        if (employee.TempRole == "Employee")
                        {
                            var result = await _userManager.CreateAsync(dbEmployee, dbEmployee.SeedPassword);
                            if (result.Succeeded == false)
                            {
                                throw new Exception("This user can't be added - " + result.ToString());
                            }

                            if (await _userManager.IsInRoleAsync(dbEmployee, "Employee") == false)
                            {
                                await _userManager.AddToRoleAsync(dbEmployee, "Employee");
                            }
                        }

                        db.Update(dbEmployee);
						db.SaveChanges();
					}
				}
			}
			catch
			{
				String msg = "employees added:" + intEmployeesAdded;
				throw new InvalidOperationException(msg);
			}
		}
	}
}
