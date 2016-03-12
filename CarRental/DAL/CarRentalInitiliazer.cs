using System;
using System.Collections.Generic;
using System.Data.Entity;
using CarRental.Models;

namespace CarRental.DAL {
    internal class CarRentalInitiliazer : DropCreateDatabaseIfModelChanges<CarRentalContext> {
        protected override void Seed(CarRentalContext context) {
            var cars = new List<Car> {
                new Car {Name = "Car A", DailyRate = 10, LicencePlate = "ABC123"},
                new Car {Name = "Car B", DailyRate = 20, LicencePlate = "123ABC"},
                new Car {Name = "Car C", DailyRate = 30, LicencePlate = "C#SUCK"},
                new Car {Name = "Car D", DailyRate = 15, LicencePlate = "PY7H0N"},
                new Car {Name = "Car E", DailyRate = 25, LicencePlate = "RUL3Z"},
                new Car {Name = "Car F", DailyRate = 35, LicencePlate = "HKD123"}
            };

            cars.ForEach(c => context.Cars.Add(c));
            context.SaveChanges();

            var users = new List<User> {
                new User {FirstName = "John", LastName = "Doe", Role = LoginRole.Admin, CreationDate = DateTime.Now},
                new User {
                    FirstName = "Mad",
                    LastName = "Max",
                    Role = LoginRole.Employee,
                    CreationDate = DateTime.Now - TimeSpan.FromDays(1)
                },
                new User {
                    FirstName = "Han",
                    LastName = "Solo",
                    Role = LoginRole.Client,
                    CreationDate = DateTime.Now - TimeSpan.FromHours(2)
                },
                new User {
                    FirstName = "Leia",
                    LastName = "Organa",
                    Role = LoginRole.Client,
                    CreationDate = DateTime.Now - TimeSpan.FromHours(3)
                },
                new User {
                    FirstName = "Luke",
                    LastName = "Skywalker",
                    Role = LoginRole.Client,
                    CreationDate = DateTime.Now - TimeSpan.FromHours(5)
                }
            };

            users.ForEach(u => context.Users.Add(u));
            context.SaveChanges();

            var rents = new List<Rent> {
                new Rent {
                    CarId = 1,
                    UserId = 1,
                    StartTime = DateTime.Now - TimeSpan.FromDays(1),
                    EndTime = DateTime.Now
                },
                new Rent {
                    CarId = 2,
                    UserId = 2,
                    StartTime = DateTime.Now - TimeSpan.FromDays(2),
                    EndTime = DateTime.Now + TimeSpan.FromDays(5)
                },
                new Rent {
                    CarId = 3,
                    UserId = 3,
                    StartTime = DateTime.Now - TimeSpan.FromDays(3),
                    EndTime = DateTime.Now + TimeSpan.FromDays(4)
                },
                new Rent {
                    CarId = 4,
                    UserId = 4,
                    StartTime = DateTime.Now - TimeSpan.FromDays(5),
                    EndTime = DateTime.Now + TimeSpan.FromDays(3)
                }
            };

            rents.ForEach(r => context.Rents.Add(r));
            context.SaveChanges();
        }
    }
}