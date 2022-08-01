Feature: Pizzahub

Placing a pizza order 

@tag1
Scenario: pizza order should be placed by me 
	Given i have to navigate to pizzahub page
	Then click on all pizza button and add pizza to cart
	Then click on veg pizza button and add pizza to cart
	Then click on view cart butoon to check order list
	Then add or remove pizzas 
	When click on checkout button order should be placed
