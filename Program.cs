// See https://aka.ms/new-console-template for more information
using Mapster;
using MapsterDTOs;
using MapsterDTOs.DTOs;
using MapsterDTOs.Models;
using MapsterMapper;
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


//Usando com injeção de dependencia:
TesteInjecaoDependencia injecaoDependencia = new TesteInjecaoDependencia();
injecaoDependencia.Teste();
public class TesteInjecaoDependencia {

    public IMapper _mapper;

    public void Teste()
    {
        User user = new User();

        user.Name = "Samuel";
        user.Adress = "Pinheiros";
        user.IdUser = 2;
        user.LastName = "Portes";

        //Com injeção de dependencia
        var config = new TypeAdapterConfig();

        MapsterConfig.Configure();
        _mapper = new Mapper(config);
        MapsterWithDependencyInjection mapsterWithDependencyInjection = new MapsterWithDependencyInjection(_mapper);
        var newUser = mapsterWithDependencyInjection.GetUser(user);
        Console.WriteLine(newUser.Name + ", " + newUser.Adress);
        Console.ReadLine();
    }

}
