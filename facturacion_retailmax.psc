Algoritmo facturacion_retailmax
	Repetir
		Escribir "Código del producto (0 para finalizar)"
		Leer codigo
		Si codigo <> "0" Entonces
			Escribir "Nomnbre del producto: "
			Leer nombreProducto
			Escribir "Ingrese la cantidad requerida: "
			Leer cantidad
			Escribir "Precio unitario: "
			Leer precioUnitario
			//Cálculo del subtotal del producto
			subtotalProducto = CalcularSubtotal(cantidad, precioUnitario)
			totalBruto = totalBruto + subtotalProducto
			numProductos = numProductos + 1
			// Mostrar el subtotal
			Escribir "Subtotal: S/ " subtotalProducto
		FinSi
	Hasta Que codigo="0"
	//Llamado a funciones
	montoDescuento = CalcularDescuento (totalBruto)
	montoIGV = CalcularIGV(totalBruto - montoDescuento)
	totalFinal = (totalBruto - montoDescuento) + montoIGV
	//Mostrar resultados
	MostarTicket(numProductos, totalBruto, montoDescuento, montoIGV, totalFinal)
FinAlgoritmo

Funcion subtotal <- CalcularSubtotal(_cantidad,_precio)
		subtotal = _cantidad * _precio
FinFuncion

Funcion descuento <- CalcularDescuento(montoTotal)
	//Reglas del negocio
	Si montoTotal > 300 Entonces
		descuento = montoTotal * 0.10
	SiNo
		Si montoTotal > 150 Entonces
		descuento = montoTotal * 0.05
		SiNo
			descuento = 0
		FinSi
	FinSi
FinFuncion

Funcion igv <- CalcularIGV(monto) 
		igv = monto*0.18
FinFuncion

Funcion MostarTicket(numProductos, totalBruto, montoDescuento, montoIGV, totalFinal)
	//Mostrar formato del ticket
	Escribir "================================================================="
	Escribir "===============TICKET DE COMRPA - RETAILMAX======================"
	Escribir "================================================================="
	Escribir "Productos comprados: " numProductos
	Escribir "Total bruto: " totalBruto
	Escribir "Descuento aplicado: " montoDescuento
	Escribir "IGV (18%): " montoIGV
	Escribir "-----------------------------------------------------------------"
	Escribir "TOTAL A PAGAR: S/" totalFinal
FinFuncion
