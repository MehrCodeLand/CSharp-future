public class User 
{
	public int UserId {get; set; }
	
	// or Email Address
	public string PhoneNumber {get; set;}
	
	public bool ConfirmPhoneNumber {get; set;}
	
	public string ConfirmCode {get; set;}
	
	public DateTime ConfirmCodeCreateData {get; set;}
	
	public DisplayName {get; set;}
	
	public string Password {get; set; }
	
	public DateTime RegisterTime {get; set;}
	
	// Important one!
	public bool IsDelete {get; set;}
	
	public string Avatar {get; set;}
	
}