import { createAction, props } from '@ngrx/store';
import { Customer } from './customer.model';

// Load Customer Actions
export const loadCustomers = createAction('[Customer List] Load Customers');
export const loadCustomersSuccess = createAction(
  '[Customer List] Load Customers Success',
  props<{ customers: Customer[] }>()
);
export const loadCustomersFailure = createAction(
  '[Customer List] Load Customers Failure',
  props<{ error: string }>()
);

// Create Customer actions
export const createCustomer = createAction(
  '[Create Customer] Create Customer',
  props<{ customer: Customer }>()
);
export const createCustomerSuccess = createAction(
  '[Create Customer] Create Customer Success',
  props<{ customer: Customer }>()
);
export const createCustomerFailure = createAction(
  '[Create Customer] Create Customer Failure',
  props<{ error: string }>()
);


// Update Customer Actions
export const updateCustomer = createAction(
  '[Update Customer] Update Customer',
  props<{ customer: Customer }>()
);
export const updateCustomerSuccess = createAction(
  '[Update Customer] Update Customer Success',
  props<{ customer: Customer }>()
);
export const updateCustomerFailure = createAction(
  '[Update Customer] Update Customer Failure',
  props<{ error: string }>()
);

// Delete Customer Actions
export const deleteCustomer = createAction(
  '[Delete Customer] Delete Customer',
  props<{ id: number }>()
);
export const deleteCustomerSuccess = createAction(
  '[Delete Customer] Delete Customer Success',
  props<{ id: number }>()
);
export const deleteCustomerFailure = createAction(
  '[Delete Customer] Delete Customer Failure',
  props<{ error: string }>()
);
