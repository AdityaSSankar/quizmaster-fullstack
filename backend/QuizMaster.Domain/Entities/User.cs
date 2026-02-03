using System;

public class User
{
	public Guid ID { get; set; }
	public string UserName { get; private set; }
	public string Email { get; private set; }
	private User()
	{
	}
	public User(string UserName, string Email) 
	{
		ID=Guid.NewGuid();
		UserName=UserName;
		Email=Email;
	}
}
