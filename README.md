1. Separar responsabilidades ya que todo esta en una misma clase.
2. Abierto a adicion y cerrado para modificaciones en los descuentos y tenerlos de todos los tipos posibles
3. Inversion de dependencias para notificaciones y almacenamiento del pedido, no deben depender de una clase en especifico.
4. Segregar interfaces, cada una con una tarea en especifica y luego se hereda en la clase principal.




# Construccion
## Tener en cuenta, alta cohesion, bajo acomplamiento

- Crear las interfaces de cada tarea en especifico.
- Crear clases para cada operacion instanciando las interfaces.
- Hacer las inversion de dependencias en la clase principal para que no dependan de la clase.
- Crear metodos en base a las dependencias dadas.


# Entidades
- OrderService -> return (all methods) - extend all interfaces
- Discount -> extend ICalculateDicount
- Notification -> extend INotification
- OrderSaved -> extend IOrderSaved


## Interfaces
- ICalculateDiscount -> Calculate(price) - return (console) 
- INotification -> Notification() - return (console)
- IOrderSaved -> OrderSaved() - return (console) 