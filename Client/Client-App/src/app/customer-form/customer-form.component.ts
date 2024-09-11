import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MatDialogRef } from '@angular/material/dialog';
import { Store } from '@ngrx/store';
import { Customer } from '../store/customer.model';
import { createCustomer } from '../store/customer.actions';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-customer-form',
  templateUrl: './customer-form.component.html',
  styleUrl: './customer-form.component.css'
})
export class CustomerFormComponent {
  customerForm: FormGroup;

  constructor(
    private fb: FormBuilder,
    private store: Store,
    private dialogRef: MatDialogRef<CustomerFormComponent>,
    private snackBar: MatSnackBar
  ) {
    this.customerForm = this.fb.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]]
    });
  }

  onCreate() {
    if (this.customerForm.valid) {
      const newCustomer: Customer = this.customerForm.value;
      this.store.dispatch(createCustomer({ customer: newCustomer }));
      this.snackBar.open('Customer created successfully', 'Close', {
        duration: 3000,
      });
      this.dialogRef.close();
    }
  }

  onCancel() {
    this.dialogRef.close();
  }
}
