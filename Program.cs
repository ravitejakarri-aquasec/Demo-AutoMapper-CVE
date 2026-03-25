using AutoMapper;

var config = new MapperConfiguration(cfg =>
{
    cfg.CreateMap<UserEntity, UserDto>();
});

var mapper = config.CreateMapper();

var entity = new UserEntity
{
    Id = 1,
    Name = "test-user"
};

var dto = mapper.Map<UserDto>(entity);

Console.WriteLine($"Mapped user: {dto.Id} - {dto.Name}");

public class UserEntity
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}

public class UserDto
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
}
