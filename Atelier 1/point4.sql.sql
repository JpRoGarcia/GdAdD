update  p
set p.stock = p.stock + 50
FROM productos p
INNER JOIN detalles d ON p.id_producto = d.id_producto
INNER JOIN facturas f ON d.id_factura = f.num_factura
INNER JOIN modo_pagos m ON f.num_pago = m.num_pago
where (m.nombre != 'tarjeta débito') And (p.nombre like 'C%')