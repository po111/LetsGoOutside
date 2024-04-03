namespace LetsGoOutside.Core.Contracts
{
    public interface IOrganizerService
    {
        Task<bool> ExistsByIdAsync(string userId);
        Task<bool> OrganizerWithPhoneNumberExistsAsync(string phoneNumber);
        Task<bool> OrganizerWithSameNameExistsAsync(string name);

        Task CreateAsync(string userId, string phoneNumber, string name, string website = "", string briefPresentation = "");

        Task<int?> GetOrganizerIdAsync(string userId);
    }
}
