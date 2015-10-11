package com.microsoft;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

/**
 * Created by mmelusky on 10/10/2015.
 */
public class Main {

    public static void main(String[] args) {
        Person person1 = new Person("Tom Brady");
        Person person2 = new Person("Andrew Luck");
        Person person3 = new Person("Brian Hoyer");
        Person person4 = new Person("Eli Manning");

        List<Person> people = new ArrayList<>();
        people.add(person1);
        people.add(person2);
        people.add(person3);
        people.add(person4);

        /*
        for (Person person : people) {
            System.out.println(person.getName());
        }
        */

        // Old way
        // Collections.sort(people, new PersonComparator());

        // New way
        people.sort((p1, p2) -> (p1.getName().compareTo(p2.getName())));
        people.forEach(p -> System.out.println(p.getName()));




    }

}
