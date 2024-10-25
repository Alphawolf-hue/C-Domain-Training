---------------------------------------TRANSACTION/ROLLBACK------------------------------------------------------------------------------------------------------
begin transaction 
INSERT INTO sales.orders(customer_id, order_status,
order_date, required_date, shipped_date, store_id,staff_id) 
VALUES(49,4,'20170228','20170301','20170302',2,6);
INSERT INTO sales.order_items(order_id, item_id, product_id, quantity, list_price,discount) VALUES(93,16,8,2,269.99,0.07)
if @@ERROR=0
begin
commit transaction
print 'Insertion Sucessful!...'
end
else 
begin
rollback transaction
print 'Something went wrong while insertion'
end 