Feature: DemoQa
	Form Filling

@firstScenario
Scenario: Automating the webpage 
	Given Navigate to the url
	And Go to forms Section
	When Click on Form
	Then Click on Practice Form
	Then Enter firstname, lastname, email,Click on Radiobutton,Enter mobile Number,DOB,Subjects,
	And  Click on Checkbox,Select a Picture,Enter current Address
	When Select State and City, Click on Submit Button
	Then Close the Browser

	