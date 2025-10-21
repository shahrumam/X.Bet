using System.ComponentModel.DataAnnotations;

namespace DanaBet.DBModel
{
    public class LeagueUser
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "وارد کردن نام الزامی است")]
        public string Firstname { get; set; } = string.Empty; // <<<< تغییر کلیدی: حذف 'required' و افزودن مقدار اولیه

        [Required(ErrorMessage = "وارد کردن نام خانوادگی الزامی است")]
        public string Lastname { get; set; } = string.Empty; // <<<< تغییر کلیدی: حذف 'required' و افزودن مقدار اولیه

        public string? Mobile { get; set; }

        public int LeagueId { get; set; }
        public virtual League? League { get; set; }
    }
}