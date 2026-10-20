
# Gym Membership System

## Project Proposal and Functional Requirements Specification

------------------------------------------------------------------------

## 1. Project Overview

The Gym Management System lets a gym manage its members, membership
plans, trainers, classes, and payments without paper records.
Administrators use a WinForms desktop application. Members and trainers
use a web application. Both connect to one ASP.NET Web API backed by a
relational database.

## 2. User Roles

  -----------------------------------------------------------------------
  Role                                Responsibilities
  ----------------------------------- -----------------------------------
  **Administrator**                   Manages users, membership plans,
                                      trainers, classes, and system
                                      settings. Registers members, renews
                                      memberships, records payments, and
                                      checks check-ins.

  **Trainer**                         Views assigned members and own
                                      classes; records member progress
                                      notes.

  **Member**                          Views own membership, payments, and
                                      class schedule; books and cancels
                                      classes.

  **System**                          Validates data, calculates
                                      membership status, and generates
                                      reports.
  -----------------------------------------------------------------------

## 3. Desktop Application Requirements (Phase 1: WinForms)

Used by administrators. Phase 1 uses in-memory storage; the API replaces
it in Phase 2.

  -----------------------------------------------------------------------
  ID                                  Requirement
  ----------------------------------- -----------------------------------
  D1                                  Login form for administrators
                                      (username and password).

  D2                                  Main form with menu and toolbar for
                                      navigating between forms.

  D3                                  Add, edit, and delete members (ID,
                                      full name, gender, date of birth,
                                      phone, email, address, join date).

  D4                                  Manage membership plans (name,
                                      duration, price).

  D5                                  Assign a plan to a member; the
                                      system calculates start date,
                                      expiry date, and status
                                      (Active/Expired).

  D6                                  Display members in a ListView with
                                      search and filter (by name, ID,
                                      plan, status).

  D7                                  Add, edit, and delete trainers
                                      (name, specialty, phone) and assign
                                      a trainer to a member.

  D8                                  Create, edit, and delete classes
                                      (name, trainer, day, time,
                                      capacity).

  D9                                  Book a member into a class and
                                      cancel a booking.

  D10                                 Record member check-in and
                                      check-out (attendance) for the day.

  D11                                 Record payments (member, amount,
                                      date, method) and show outstanding
                                      balance.

  D12                                 Input validation on all forms
                                      (required fields, valid email and
                                      phone, amount greater than 0, valid
                                      dates, capacity greater than 0).

  D13                                 Status messages and confirmation
                                      dialogs (for example, before
                                      deleting).

  D14                                 Simple report view: total members,
                                      active vs. expired members, today's
                                      attendance, total payments.

  D15                                 Manage user accounts (add, edit,
                                      deactivate, assign role:
                                      Administrator, Trainer, or Member).
  -----------------------------------------------------------------------

## 4. API and Data Layer Requirements (Phase 2)

  -----------------------------------------------------------------------
  ID                                  Requirement
  ----------------------------------- -----------------------------------
  A1                                  REST API (ASP.NET Web API) with
                                      CRUD endpoints for Members, Plans,
                                      Trainers, Classes, Payments, and
                                      Users.

  A2                                  Endpoints for subscription, class
                                      booking, cancellation, check-in,
                                      and reports.

  A3                                  Database tables: Users, Members,
                                      Plans, Subscriptions, Trainers,
                                      Classes, Bookings, Attendance,
                                      Payments, with foreign-key
                                      relationships.

  A4                                  Unique constraint on (ClassId,
                                      MemberId) to prevent duplicate
                                      bookings.

  A5                                  Repository and service layers; DTOs
                                      for all requests and responses.

  A6                                  Error handling with proper HTTP
                                      status codes and clear messages.

  A7                                  Basic logging (errors and key
                                      actions such as payment, booking,
                                      and cancellation).

  A8                                  Desktop application connected to
                                      the API in place of in-memory
                                      storage.

  A9                                  Token-based authentication with
                                      role checks on protected endpoints.
  -----------------------------------------------------------------------

## 5. Web Application Requirements (Phase 3)

  -----------------------------------------------------------------------
  ID                                  Requirement
  ----------------------------------- -----------------------------------
  W1                                  Login for members and trainers, and
                                      sign-up for new members.

  W2                                  Dashboard showing the member's
                                      membership status, upcoming
                                      classes, and recent payments.

  W3                                  Class list with search and filter
                                      (name, trainer, day).

  W4                                  Class detail page showing trainer,
                                      time, and remaining spots.

  W5                                  Book a class and cancel a booking.

  W6                                  "My Membership" page showing plan,
                                      expiry date, payment history, and
                                      attendance history.

  W7                                  Administrator pages: CRUD for
                                      members, plans, trainers, classes,
                                      and payments.

  W8                                  Trainer pages: assigned members,
                                      own classes, and progress notes.

  W9                                  Report page and dashboard with
                                      charts: members, revenue,
                                      attendance.

  W10                                 Responsive layout (desktop and
                                      mobile).

  W11                                 All data accessed through the same
                                      API as the desktop application.
  -----------------------------------------------------------------------

## 6. Business Rules

1.  A member can check in only if the membership is Active (not
    expired).
2.  A member cannot hold two active subscriptions of the same plan at
    the same time.
3.  A class booking is accepted only if the number of active bookings is
    below the class capacity. When capacity is reached, new bookings are
    rejected with a "Class is full" message.
4.  A member cannot book the same class twice.
5.  Cancelling a booking frees one place.
6.  Capacity cannot be reduced below the current number of bookings.
7.  A membership expiry date is the start date plus the duration of the
    plan.
8.  A member with existing subscriptions or payments cannot be deleted;
    the member must be deactivated instead.
9.  A payment amount must be greater than 0 and is recorded against a
    member.
10. Only an Administrator can record payments and check-ins.

## 7. Reports

-   Total number of members.
-   Active and expired members.
-   Total payments (income) per month.
-   Attendance (check-ins) per day.
-   Bookings per class and class fill rate (bookings divided by
    capacity).

## 8. Deliverables

Source code (Desktop, API, Web), database schema, documentation (5 to 10
pages), and group contribution report.
