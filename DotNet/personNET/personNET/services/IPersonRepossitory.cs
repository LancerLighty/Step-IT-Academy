using personNET.models;

namespace personNET.services
{
    public interface IPersonRepossitory
    {
        PersonDto Get(int id);
        List<PersonDto> GetAll(string? firstname, string? lastname, int? age);
        void Create(CreatePersonDto person);
        void Update(UpdatePersonDto person);
        void Delete(int id);
    }
}
