package com.servidor.gestor_aas.controladores;

import org.springframework.beans.factory.annotation.Value;
import org.springframework.http.HttpStatus;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;


import io.swagger.v3.oas.annotations.Operation;
import io.swagger.v3.oas.annotations.responses.ApiResponse;
import io.swagger.v3.oas.annotations.responses.ApiResponses;

@Controller
@RequestMapping("/")
public class Web_Controller {

    @Value("${spring.application.name}")
    String appName;
    
	@Operation(summary = "Página principal de la aplicación web", description= "Está es la página principal para la aplicación web.")
	@ApiResponses(value = {
	        @ApiResponse(responseCode = "400", description = "Se ha producido un error"),
	        @ApiResponse(responseCode = "404", description = "Recurso no encontrado")
	        })
	@GetMapping(path="/",produces = MediaType.TEXT_HTML_VALUE)	
	public String getIndex(Model mode) {
		System.out.println("Página principal");
		return "index.html";
	}

}
