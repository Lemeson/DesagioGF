import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Cliente } from '../models/Cliente';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AlunoService {

  baseUrl = `${environment.mainUrl}/api/aluno`;

  constructor(private http: HttpClient) { }

  getAll(): Observable<Cliente[]>{
    return this.http.get<Cliente[]>(`${this.baseUrl}`);
  }

  getById(id: number): Observable<Cliente> {
    return this.http.get<Cliente>(`${this.baseUrl}/${id}`);
  }
}
