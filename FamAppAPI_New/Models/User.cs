namespace FamAppAPI_New.Models;

public class Users {
	
	// Innate Columns
	public int    Id            { get; set; }
	public string Username      { get; set; }
	public string Email         { get; set; }
	public string PasswordHash { get; set; }
	
	// 1-n Relations
	public List<Note> Notes { get; set; }
}