package com.servidor.gestor_aas.pojos;

import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.Size;

public class Activo_pojo {
	
    @NotBlank
    @Size(min = 0, max = 20)
	private String nombre;

	public Activo_pojo() {
		super();
		// TODO Auto-generated constructor stub
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}
	
	

}
