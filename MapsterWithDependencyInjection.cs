// See https://aka.ms/new-console-template for more information
using MapsterDTOs.DTOs;
using MapsterDTOs.Models;
using MapsterMapper;

public class MapsterWithDependencyInjection
{

    private readonly IMapper _mapper;

    public MapsterWithDependencyInjection(IMapper mapper)
    {
        _mapper = mapper;
    }

    public UserViewModel GetUser(User user)
    {
        return _mapper.Map<UserViewModel>(user);
    }
}