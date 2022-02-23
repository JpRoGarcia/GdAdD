select     c.apellido,
    sum(d.precio * d.cantidad) [total]

from facturas f

join clientes c on f.id_cliente = c.id_cliente
join modo_pagos m on m.num_pago = f.num_pago
join detalles d on d.id_factura = f.num_factura
join productos p on p.id_producto = d.id_producto
join categorias k on k.id_categoria = p.id_categoria
where m.nombre = 'efectivo' AND k.nombre = 'Mercado'
group by c.apellido
order by c.apellido