import { Component, TemplateRef } from '@angular/core';
import { Aluno } from '../models/Aluno';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { AlunoService } from './aluno.service';

@Component({
  selector: 'app-alunos',
  templateUrl: './alunos.component.html',
  styleUrls: ['./alunos.component.css']
})
export class AlunosComponent {

  modalRef?: BsModalRef;
  alunoForm: FormGroup = new FormGroup({});
  title = 'Alunos';
  alunoSelecionado: Aluno | null = null;
  simpleText: string = '';

  public alunos: Aluno[] = []; 

  //= [
  //{id: 1,nome : 'Maria', sobrenome : 'Silva', telefone : '123456'},
  //{id: 2,nome : 'Marta', sobrenome : 'Marta', telefone : '123456'},
  //{id: 3,nome: 'Leandro', sobrenome : 'Querido', telefone : '123456'},
  //  {id: 4,nome : 'Pedro', sobrenome : 'Tesouro', telefone : '123456'},
  //  {id: 5,nome : 'Zeca', sobrenome : 'Silva', telefone : '123456'},
  //  {id: 6,nome: 'Feni', sobrenome : 'Silva', telefone : '123456'},
  //  {id: 7,nome : 'João', sobrenome : 'Silva', telefone : '123456'},
  //];


 
  openModal(template: TemplateRef<any>) {
    this.modalRef = this.modalService.show(template);
  }

  constructor(private fb: FormBuilder, 
    private modalService: BsModalService,
    private alunoService: AlunoService){
    this.criarForm();
    }

  ngOnInit(){
    this.carregarAluno();
  }


  carregarAluno() {
  this.alunoService.getAll().subscribe({
    next: (alunos: Aluno[]) => {
      this.alunos = alunos;
    },
    error: (erro: any) => {
      console.error(erro);
    }
  });
}


  criarForm(){
    this.alunoForm = this.fb.group({
      nome: ['', Validators.required], 
      sobrenome: ['', Validators.required],
      telefone: ['', Validators.required],
    }); //injeção de dependencia
  }

  alunoSubmit(){
    console.log(this.alunoForm.value);
  }

  limparSelecao(){
    this.alunoSelecionado = null;
  }

  alunoSelect(aluno: Aluno){
    this.alunoSelecionado = aluno;
    this.alunoForm.patchValue(aluno); //patchValue é um método do FormGroup. Aluno tem o mesmo propriedades criaForm o patchValue vai preencher o formulário com os dados do aluno selecionado. Ele reconhece automaticamente.
  }

}
