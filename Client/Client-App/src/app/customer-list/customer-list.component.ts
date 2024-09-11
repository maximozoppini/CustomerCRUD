import { ChangeDetectionStrategy, Component } from '@angular/core';
import { map, Observable, of, tap } from 'rxjs';
import { Customer } from '../store/customer.model';
import { Store } from '@ngrx/store';
import { deleteCustomer, loadCustomers, updateCustomer } from '../store/customer.actions';
import { CustomerState } from '../store/customer.reducer';
import { CellValueChangedEvent, ColDef, GridReadyEvent } from 'ag-grid-community';
import * as CustomerActions from '../store/customer.actions';
import { MatSnackBar } from '@angular/material/snack-bar';
import { selectAllCustomers } from '../store/customer.selectors';
import { MatDialog } from '@angular/material/dialog';
import { CustomerFormComponent } from '../customer-form/customer-form.component';

@Component({
  selector: 'app-customer-list',
  templateUrl: './customer-list.component.html',
  styleUrl: './customer-list.component.css',
  changeDetection: ChangeDetectionStrategy.OnPush
})
export class CustomerListComponent {
  customers$: Observable<Customer[]>;
  columnDefs: ColDef[] = [
    { field: 'id', headerName: 'ID',},
    { field: 'firstName', headerName: 'Name', editable: true },
    { field: 'lastName', headerName: 'Last name', editable: true },
    { field: 'email', headerName: 'Email', editable: true },
    {
      headerName: 'Actions',
      field: 'actions',
      cellRenderer: (params: any) => {
        const button = document.createElement('button');
        button.innerHTML = 'Delete';
        button.addEventListener('click', () => this.deleteCustomer(params.data.id));
        return button;
      }
    }
  ];

  constructor(private store: Store<{ customerState: CustomerState }>
    , private snackBar: MatSnackBar
    , private dialog: MatDialog) {
    this.customers$ = this.store.select(selectAllCustomers).pipe(
      map((customers) => {
        let newCustomers = customers.map(customer => {return {...customer}});
        return newCustomers;
      }),
      tap((customers)=> console.log(customers))
    );
  }

  ngOnInit() {
    this.store.dispatch(loadCustomers());
  }

  onCellValueChanged(event: CellValueChangedEvent) {
    if (event.oldValue !== event.newValue) {
      const updatedCustomer: Customer = { ...event.data };
      this.store.dispatch(updateCustomer({ customer: updatedCustomer }));
    }
  }

  deleteCustomer(id: number) {
    if (confirm('Are you sure you want to delete this customer?')) {
      this.store.dispatch(deleteCustomer({ id }));
      this.snackBar.open('Customer deleted successfully', 'Close', {
        duration: 3000,
      });
    }
  }

  openCreateCustomerDialog() {
    const dialogRef = this.dialog.open(CustomerFormComponent, {
      width: '400px',
      disableClose: true
    });

  }

}
