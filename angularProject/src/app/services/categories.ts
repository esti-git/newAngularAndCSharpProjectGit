import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http'; 
import { Observable } from 'rxjs';

/**
 * הגדרת ה-Interface של הקטגוריה.
 */
export interface Category {
 id: number | null;
 name: string;
}

@Injectable({
  providedIn: 'root'
})
export class CategoriesService {
  
  // ✅ שינוי: מוודאים שיש HTTP במקום HTTPS
 private apiUrl = 'http://localhost:5062/api/Category'; 

  constructor(private http: HttpClient) { }

  /**
   * קוראת ל-API ומחזירה את רשימת הקטגוריות.
   */
  getCategories(): Observable<Category[]> {
    return this.http.get<Category[]>(this.apiUrl);
  }
}