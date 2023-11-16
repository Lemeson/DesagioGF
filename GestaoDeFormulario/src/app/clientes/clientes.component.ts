import { Component, TemplateRef } from '@angular/core';
import { Cliente } from '../models/Cliente';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { AlunoService } from './cliente.service';

@Component({
  selector: 'app-alunos',
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class AlunosComponent {

  modalRef?: BsModalRef;
  alunoForm: FormGroup = new FormGroup({});
  title = 'Alunos';
  alunoSelecionado: Cliente | null = null;
  simpleText: string = '';

  public alunos: Cliente[] = []; 



 
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
    next: (alunos: Cliente[]) => {
      this.clientes = clientes;
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
    this.clienteSelecionado = null;
  }

  alunoSelect(aluno: Cliente){
    this.clienteSelecionado = cliente;
    this.cliente teForm.patchValue(cliente); //patchValue é um método do FormGroup. Aluno tem o mesmo propriedades criaForm o patchValue vai preencher o formulário com os dados do aluno selecionado. Ele reconhece automaticamente.
  }

}
