update  p
set p.precio = p.precio * 1.15
FROM productos p
INNER JOIN categorias c ON p.id_categoria = c.id_categoria
where c.nombre != 'Ferreteria'