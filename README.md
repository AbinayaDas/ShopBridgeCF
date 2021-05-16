# ShopBridgeCF
User : ProductAdmin
Actions:
1)Add an item to the Inventory
  POST : <siteURL>/api/Items | Request body - JSON
  
2)Lists all Items
  GET : <siteURL>/api/Items
  
3)Modifies an existing item
  PUT : <siteURL>/api/Items/5
  
4)Gets specific Item with its unique Id
  GET : <siteURL>/api/Items/{id}
  
5)Deletes an item with its ID
  DELETE : <siteURL>/api/Items/5
