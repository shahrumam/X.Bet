using System.ComponentModel.DataAnnotations;
namespace DanaBet.DBModel;
public class LeagueUser
{
    public int Id { get; set; }

    [Required(ErrorMessage = "نام اجباری است")]
    public string Firstname { get; set; } = string.Empty;

    [Required(ErrorMessage = "نام خانوادگی اجباری است")]
    public string Lastname { get; set; } = string.Empty;

    [Required(ErrorMessage = "موبایل اجباری است")]
    public string Mobile { get; set; } = string.Empty;

    public int LeagueId { get; set; }
}
