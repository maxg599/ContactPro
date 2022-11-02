using ContactPro.Models;




namespace ContactPro.Services.Interfaces
{
    public interface IAddressBookService
    {
        Task AddContactToCategoryAsync(int categoryId, int contactId);
        Task<bool> IsConatactInCategory(int categoryId, int contactId);

        Task<IEnumerable<Category>> GetUserCategoriesAsync(string userId);
        Task<ICollection<int>> GetContactCategoryIdAsync(int contactId);
        Task<ICollection<Category>> GetContactCategoriesAsync(int contactId);
        Task RemoveContactFromCategoryAsync(int categoryId, int contactId);


        IEnumerable<Contact> SearchForContacts(string searchString, string userId);

    }
}
