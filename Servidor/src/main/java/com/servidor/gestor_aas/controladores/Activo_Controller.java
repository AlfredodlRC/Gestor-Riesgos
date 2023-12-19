package com.servidor.gestor_aas.controladores;


import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestParam;
import org.springframework.web.bind.annotation.RestController;

import com.servidor.gestor_aas.pojos.Activo_pojo;

import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.responses.ApiResponses;
import io.swagger.v3.oas.annotations.responses.ApiResponse;



@RestController
@RequestMapping("/activos")
public class Activo_Controller {

	@Operation(summary = "Get a book by its id", description= "Customer must exist")
	@ApiResponses(value = {
	        @ApiResponse(responseCode = "400", description = "Invalid ID supplied"),
	        @ApiResponse(responseCode = "404", description = "Customer not found")
	        })
	@GetMapping(path="/{id}",produces = MediaType.APPLICATION_JSON_VALUE)	
	public ResponseEntity<Activo_pojo> getPersona(@PathVariable int id) {
		System.out.println("Buscando persona con id: " + id);
		Activo_pojo activo = new Activo_pojo();
		activo.setNombre("primer activo");
		return new ResponseEntity<Activo_pojo>(activo,HttpStatus.OK);//200 OK
		
		
		/*
		if(activo != null) {
			return new ResponseEntity<Activo_pojo>(activo,HttpStatus.OK);//200 OK
		}else {
			return new ResponseEntity<Activo_pojo>(HttpStatus.NOT_FOUND);//404 NOT FOUND
		}*/
	}

}
