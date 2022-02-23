delete 
from clientes 
WHERE id_cliente not IN 
       (
       SELECT  f.id_cliente 
       FROM    facturas f
       WHERE   f.id_cliente is not null
       )