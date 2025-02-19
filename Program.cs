// See https://aka.ms/new-console-template for more information
using Mapster;
using MapsterDTOs.DTOs;
using MapsterDTOs.Models;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;

//Usando mapster sem injeção de dependência
User user = new User();

user.Name = "Eduarda";
user.Adress = "Pinheiros";
user.IdUser = 1;
user.LastName = "Portes";

TypeAdapterConfig<User, UserViewModel>.NewConfig();
var userViewModel = user.Adapt<UserViewModel>();

Console.WriteLine(userViewModel.Name + ", " + userViewModel.Adress);
Console.ReadLine();