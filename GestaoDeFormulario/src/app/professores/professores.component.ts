import { Component, TemplateRef } from '@angular/core';
import { Professor } from '../models/Professor';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-professores',
  templateUrl: './professores.component.html',
  styleUrls: ['./professores.component.css']
})
export class ProfessoresComponent {

  modalRef?: BsModalRef;
  title = "Professores";
  //professorSelecionado: Professor;
  professorSelecionado: Professor | null = null;
  professorForm: FormGroup = new FormGroup({});
  simpleText: string = '';


  professores = [
    
    {id: 1,nome : 'Maria', disciplina : 'Matemática'},
    {id: 2,nome : 'Marta', disciplina : 'Português'},
    {id: 3,nome: 'Leandro', disciplina : 'História'},
    {id: 4,nome : 'Pedro', disciplina : 'Geografia'},
    {id: 5,nome : 'Zeca', disciplina : 'Física'},
    
  ];

 
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  constructor(private fb: FormBuilder, private modalService: BsModalService){
    this.criarForm();
    }

  ngOninit(){}

  criarForm(){
    this.professorForm = this.fb.group({
      nome: ['', Validators.required], 
      disciplina: ['', Validators.required],
    }); //injeção de dependencia
  }

  alunoSubmit(){
    console.log(this.professorForm.value);
  }

professorSelect(professor: Professor){
  this.professorSelecionado = professor;
  this.professorForm.patchValue(professor); 
}

  limparSelecao(){
    this.professorSelecionado = null;
  }

  professorSubmit(){
    console.log(this.professorForm.value);
  }
}
