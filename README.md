# Email-Fundraiser-Service

The goal of the Email Fundraiser Service was to create an method communicating, organizing, and displaying the fundraiser events that a highschool 
or organization would host.

# Project Description
The project originally was designed to utilize a test G-Mail account, and emulate the basic email operations that a service would provide. The 
hosting-organziation would create an event based off of the sport, club, or group they wanted to fundraiser for. The participants would share the
email addresses of local supporters, community members, and family members for them later to be contacted about the specific fundraiser that is 
ongoing. The donors would follow the link to the donation website and complete the fundraising process.

# Features
### Email + Password Login
  - User-login interface connected to a SQL database
  - Seperate Login form from Dashboard form
- Two-Factor Authentication (2FA)
  - Authy, Google Authenticator, etc supported
- Email verification
  - Plug in your SMTP credentials for Mailgun, Gmail, or anything else
  
![login1!](https://user-images.githubusercontent.com/43658901/187299106-1679dadb-ee97-405c-a895-c9a6e513a045.PNG)
  
### Interactive Dashboard
- Features modifying fundraising events in real time
  - Add event (i.e. Create an Event for the Varsity Boys Football team to funraise $5,000)
  - View the past, present, and future events the oraganization is hosting
- Event data is connected to a SQL database
  
