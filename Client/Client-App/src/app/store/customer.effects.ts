import { Injectable } from '@angular/core';
import { Actions, createEffect, ofType } from '@ngrx/effects';

import { loadCustomers, loadCustomersSuccess, loadCustomersFailure, createCustomer, createCustomerSuccess, createCustomerFailure, deleteCustomer, deleteCustomerSuccess, deleteCustomerFailure, updateCustomer, updateCustomerSuccess, updateCustomerFailure } from './customer.actions';
import { catchError, map, mergeMap } from 'rxjs/operators';
import { of } from 'rxjs';
import { Customer } from './customer.model';
import { CustomerService } from '../customer.service';

@Injectable()
export class CustomerEffects {
  constructor(
    private actions$: Actions,
    private customerService: CustomerService
  ) {}

  // Load all customers
  loadCustomers$ = createEffect(() =>
    this.actions$.pipe(
      ofType(loadCustomers),
      mergeMap(() =>
        this.customerService.getCustomers().pipe(
          map(customers => loadCustomersSuccess({ customers })),
          catchError(error => of(loadCustomersFailure({ error: error.message })))
        )
      )
    )
  );

  // Create a customer
  createCustomer$ = createEffect(() =>
    this.actions$.pipe(
      ofType(createCustomer),
      mergeMap(action =>
        this.customerService.createCustomer(action.customer).pipe(
          map(customer => createCustomerSuccess({ customer })),
          catchError(error => of(createCustomerFailure({ error: error.message })))
        )
      )
    )
  );


  // Update an existing customer
  updateCustomer$ = createEffect(() =>
    this.actions$.pipe(
      ofType(updateCustomer),
      mergeMap((action) =>
        this.customerService.updateCustomer(action.customer).pipe(
          map((customer: Customer) => updateCustomerSuccess({ customer })),
          catchError((error) => of(updateCustomerFailure({ error: error.message })))
        )
      )
    )
  );

  // Delete a customer
  deleteCustomer$ = createEffect(() =>
    this.actions$.pipe(
      ofType(deleteCustomer),
      mergeMap((action) =>
        this.customerService.deleteCustomer(action.id).pipe(
          map(() => deleteCustomerSuccess({ id: action.id })),
          catchError((error) => of(deleteCustomerFailure({ error: error.message })))
        )
      )
    )
  );
}
